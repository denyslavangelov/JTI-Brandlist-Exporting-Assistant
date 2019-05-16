using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Brandlist_Export_Assistant.Enums;
using Brandlist_Export_Assistant.Forms;

namespace Brandlist_Export_Assistant.Classes
{
    public class ExcelProcessor
    {
        public ExcelProcessor()
        {
            ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            MainBrandList = new List<MainBrand>();
            SubBrandList = new List<SubBrand>();
        }

        public Microsoft.Office.Interop.Excel.Application ExcelApp { get; set; }

        public Dictionary<Dictionary<int, string>, Dictionary<int, string[]>> ExcelData { get; set; }

        public string FileName { get; set; }

        public string SheetName => ExcelApp.ActiveSheet.Name;

        public int TrackerCodeColumnIndex { get; set; }

        public int GlobalLabelColumnIndex { get; set; }

        public int LocalLabelColumnIndex { get; set; }

        public int ProductTypeColumnIndex { get; set; }

        public int StatusColumnIndex { get; set; }

        public int MarketCodeColumnIndex { get; set; }

        public int SecondLocalLabelColumnIndex {get ;set; }

        public int CustomPropertyColumnIndex { get; set; }

        public int MarketCode { get; set; }

        public int CountryCoulmnIndex { get; set; }

        public string Country { get; set; }

        public string MDDShortFileName { get; set; }

        public string MDDFullFileName { get; set; }

        public string MDDPath { get; set; }

        public List<SubBrand> SubBrandList { get; set; }

        public List<MainBrand> MainBrandList { get; set; }

        public string CurrentWave => Regex.Match(this.FileName, @"(W\d{1,1})").Groups[1].Value;

        public string CountryCode => Countries.ExportCountries(Regex.Replace(Country, @"\s+", "")).FirstOrDefault(x => x.Key == Regex.Replace(Country, @"\s+", "")).Value;

        public void SetColumnIndexes(Dictionary<Dictionary<int, string>, Dictionary<int, string[]>> excelData)
        {
            // Loop through the whole data.
            foreach (var data in excelData)
            {
                // Loop through the columns only and get the index of the needed columns.
                foreach (var inner in data.Key)
                {
                    if (TrackerCodeColumnIndex == 0)
                    {
                        TrackerCodeColumnIndex = (inner.Value == "Tracker 2.0 Code") ? inner.Key : 0;
                    }

                    if (GlobalLabelColumnIndex == 0)
                    {
                        GlobalLabelColumnIndex = (inner.Value == "Label in English (Translated Questionnaire label)") ? inner.Key : 0;
                    }

                    if (LocalLabelColumnIndex == 0)
                    {
                        LocalLabelColumnIndex = (inner.Value == "Local Label in local language A (Questionnaire label)") ? inner.Key : 0;
                    }

                    if (ProductTypeColumnIndex == 0)
                    {
                        ProductTypeColumnIndex = (inner.Value == "Product Type Code") ? inner.Key : 0;
                    }

                    if (MarketCodeColumnIndex == 0)
                    {
                        MarketCodeColumnIndex = (inner.Value == "Market Code") ? inner.Key : 0;
                    }

                    if (StatusColumnIndex == 0)
                    {
                        StatusColumnIndex = (inner.Value == "Status") ? inner.Key : 0;
                    }

                    if (CountryCoulmnIndex == 0)
                    {
                        CountryCoulmnIndex = (inner.Value == "Market") ? inner.Key : 0;
                    }
                }
            }
        }

        public void PopulateBrands(MainUI ui)
        {

            /*
                Change the column indicator based on the input by user.
            */
            foreach (var inner in this.ExcelData)
            {
                if (this.GlobalLabelColumnIndex != inner.Key.FirstOrDefault(x => x.Value == ui.globalLabelBox.Text).Key)
                {
                    this.GlobalLabelColumnIndex = inner.Key.FirstOrDefault(x => x.Value == ui.globalLabelBox.Text).Key;
                }

                if (this.LocalLabelColumnIndex != inner.Key.FirstOrDefault(x => x.Value == ui.localLabelBox.Text).Key)
                {
                    this.LocalLabelColumnIndex = inner.Key.FirstOrDefault(x => x.Value == ui.localLabelBox.Text).Key;
                }

                this.SecondLocalLabelColumnIndex = inner.Key.FirstOrDefault(x => x.Value == ui.secondLanguageBox.Text).Key;
                this.CustomPropertyColumnIndex = inner.Key.FirstOrDefault(x => x.Value == ui.customPropertyBox.Text).Key;
            }

            foreach (var data in ExcelData)
            {
                foreach (var row in data.Value)
                {
                    int productType;
                    int marketCode;
                    ProductType brandType;
                    
                    var status = Status.Active;
                    var statusValue = row.Value[StatusColumnIndex];

                    /*
                        A brand or a sub brand will be a valid one if its status is "active", otherwise it would be ignored.
                    */
                    if (statusValue.Trim().ToLower() != "active")
                    {
                        status = Status.Delisted;
                    }

                    marketCode = int.TryParse(row.Value[MarketCodeColumnIndex], out marketCode) ? marketCode : 0;
                    productType = int.TryParse(row.Value[ProductTypeColumnIndex], out productType) ? productType : 0;
                    
                    this.MarketCode = marketCode;
                    this.Country = row.Value[CountryCoulmnIndex];

                    switch (productType)
                    {
                        case 1:
                            brandType = ProductType.RMC;
                            break;
                        case 2:
                            brandType = ProductType.MYO;
                            break;
                        case 3:
                            brandType = ProductType.RYO;
                            break;
                        case 9:
                            brandType = ProductType.Brand;
                            break;
                        default:
                            brandType = ProductType.Other;
                            break;
                    }

                    if (status == Status.Active && brandType == ProductType.Brand)
                    {
                        var mainBrand = new MainBrand()
                        {
                            TrackerCode = "br_" + row.Value[TrackerCodeColumnIndex],
                            GlobalLabel = row.Value[GlobalLabelColumnIndex],
                            LocalLabel = row.Value[LocalLabelColumnIndex]
                        };

                        mainBrand.BrandCode = MarketCode.ToString().Length == 2
                            ? mainBrand.TrackerCode.Substring(5, 4)
                            : mainBrand.TrackerCode.Substring(6, 4);

                        if (ui.secondLocalLanguageCheckBox.Checked)
                        {
                            mainBrand.SecondLocalLabel = row.Value[SecondLocalLabelColumnIndex];
                        }

                        if (ui.customPropertyCheckBox.Checked)
                        {
                            mainBrand.CustomProperty = row.Value[CustomPropertyColumnIndex];
                        }

                        Validator.ValidateBrand(mainBrand, row.Key, ui);

                        this.MainBrandList.Add(mainBrand);
                    }

                    if (status == Status.Active && brandType != ProductType.Brand)
                    {
                        var subBrand = new SubBrand()
                        {
                            TrackerCode = "br_" + row.Value[TrackerCodeColumnIndex],
                            GlobalLabel = row.Value[GlobalLabelColumnIndex],
                            LocalLabel = row.Value[LocalLabelColumnIndex],
                            Type = brandType
                        };

                        subBrand.BrandCode = MarketCode.ToString().Length == 2
                            ? subBrand.TrackerCode.Substring(5, 4)
                            : subBrand.TrackerCode.Substring(6, 4);

                        if (ui.secondLocalLanguageCheckBox.Checked)
                        {
                            subBrand.SecondLocalLabel = row.Value[SecondLocalLabelColumnIndex];
                        }

                        if (ui.customPropertyCheckBox.Checked)
                        {
                            subBrand.CustomProperty = row.Value[CustomPropertyColumnIndex];
                        }

                        Validator.ValidateBrand(subBrand, row.Key, ui);

                        this.SubBrandList.Add(subBrand);
                    }
                }
            }

            foreach (var brand in this.MainBrandList)
            {
                brand.PopulateBrandsWithSubBrands(this, brand);
            }

            MoveExclusiveAnswersToTheEnd();

            Validator.Validate_HasSubBrandList(this.MainBrandList, ui);

            Validator.Validate_HasMainBrand(this.SubBrandList, ui);
        }

        public void MoveExclusiveAnswersToTheEnd()
        {
            var values = new[] { "9998", "9997", "9999" };

            for (var i = this.MainBrandList.Count - 1; i >= 0; i--)
            {
                if (values.Any(this.MainBrandList[i].BrandCode.Contains))
                {
                    this.MainBrandList.Insert(this.MainBrandList.Count, this.MainBrandList[i]);
                    this.MainBrandList.RemoveAt(i);
                }
            }

            for (var i = this.SubBrandList.Count - 1; i >= 0; i--)
            {
                if (values.Any(this.SubBrandList[i].BrandCode.Contains))
                {
                    this.SubBrandList.Insert(this.SubBrandList.Count, this.SubBrandList[i]);
                    this.SubBrandList.RemoveAt(i);
                }
            }
        }

        public void PopulateLanguages(MainUI ui)
        {
            foreach (var language in Countries.ExportLanguages())
            {
                ui.localLanguagesComboBox.Items.Add(language.Value);
                ui.secondLocalLanguageComboBox.Items.Add(language.Value);
            }
        }
    }

}
