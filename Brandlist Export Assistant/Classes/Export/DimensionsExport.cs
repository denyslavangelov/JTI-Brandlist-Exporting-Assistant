using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Brandlist_Export_Assistant.Forms;
using MDMLib;
using MetroFramework;

namespace Brandlist_Export_Assistant.Classes
{
    public class DimensionsExport : Export
    {
        public Document MDD_Document { get; set; }

        public DimensionsExport(ExcelProcessor _brandlist) : base(_brandlist)
        {

        }

        private bool isSuccess { get; set; }

        public override string Dir => $@"C:\Users\{Environment.UserName}\Documents\Brandlist Export Assistant\{_brandlist.Country}\{_brandlist.FileName}\DimensionsExport\";

        public override void _Export(MainUI ui)
        {
            ui.Enabled = false;

            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }

            ExportMainAndSubBrandLists(ui);

            if (isSuccess)
            {
                ExportCountry_Q();

                SaveAndOpen(ui);
            }
            
        }

        public void ExportMainAndSubBrandLists(MainUI ui)
        {
            var mainBrandListName = $"List_Main_Brands_{_brandlist.CountryCode}";
            var subBrandListName = $"List_SubBrands_{_brandlist.CountryCode}";
            var xxxMainListName = "List_Main_Brands_XXX";
            var xxxSubBrandListName = "List_SubBrands_XXX";

            MDD_Document = new Document();

            isSuccess = true;

            try
            {
                MDD_Document.Open(_brandlist.MDDFullFileName);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(ui, "This file is already open. Please close it and they again.", "File already open.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            // {Main Brand List Creation Start}
            if (MDD_Document.Types.Exist[mainBrandListName])
            {
                MDD_Document.Types.Remove(mainBrandListName);
            }

            IElements listMainBrands = MDD_Document.CreateElements(mainBrandListName, "Brand");
            MDD_Document.Types.Add(listMainBrands, 0);

            foreach (var brand in _brandlist.MainBrandList)
            {
                IElement element = MDD_Document.CreateElement(brand.TrackerCode, brand.GlobalLabel);

                element.Properties["SKU_List"] = "{" + string.Join(",", brand.SubBrandList.Select(x => x.TrackerCode)) + "}";
                element.Properties["Value"] = int.Parse(brand.TrackerCode.Replace("br_", ""));
                element.Properties["Salto_Code"] = brand.TrackerCode;

                if (ui.customPropertyCheckBox.Checked)
                {
                    element.Properties["Custom_Property"] = brand.CustomProperty;
                }

                var values = new[] { "9998", "9999" };

                if (values.Any(brand.BrandCode.Contains))
                {
                    element.Flag = CategoryFlagConstants.flExclusive;
                }

                listMainBrands.Add(element);

                for (int i = 0; i < MDD_Document.Languages.Count; i++)
                {
                    MDD_Document.Languages.Current = MDD_Document.Languages[i].Name;

                    if (MDD_Document.Languages.Current == "ENU")
                    {
                        element.Label = brand.GlobalLabel;
                    }
                    else
                    {
                        element.Label = brand.LocalLabel;
                    }

                    if (i == 2)
                    {
                        element.Label = brand.SecondLocalLabel;
                    }
                }
            }
            // {Main Brand List Creation End}

            // {Main XXX List Creation Start}
            if (MDD_Document.Types.Exist[xxxMainListName])
            {
                MDD_Document.Types.Remove(xxxMainListName);
            }

            IElements xxxMainBrands = MDD_Document.CreateElements(xxxMainListName);
            MDD_Document.Types.Add(xxxMainBrands);

            xxxMainBrands.Reference = listMainBrands;
            xxxMainBrands.Namespace = false;
            xxxMainBrands.Inline = true;
            // {Main XXX List Creation End}


            // {Sub Brand List Creation Start}
            if (MDD_Document.Types.Exist[subBrandListName])
            {
                MDD_Document.Types.Remove(subBrandListName);
            }

            IElements listSubBrands = MDD_Document.CreateElements(subBrandListName, "SKU");
            MDD_Document.Types.Add(listSubBrands, 1);

            foreach (var subBrand in _brandlist.SubBrandList)
            {
                IElement element;

                element = MDD_Document.CreateElement(subBrand.TrackerCode, subBrand.GlobalLabel);
                element.Properties["Value"] = int.Parse(subBrand.TrackerCode.Replace("br_", ""));
                element.Properties["Salto_Code"] = subBrand.TrackerCode;

                listSubBrands.Add(element);

                for (int i = 0; i < MDD_Document.Languages.Count; i++)
                {
                    MDD_Document.Languages.Current = MDD_Document.Languages[i].Name;

                    if (MDD_Document.Languages.Current == "ENU")
                    {
                        element.Label = subBrand.GlobalLabel;
                    }
                    else
                    {
                        element.Label = subBrand.LocalLabel;
                    }

                    if (i == 2)
                    {
                        element.Label = subBrand.SecondLocalLabel;
                    }
                }
            }
            // {Sub Brand List Creation End}

            // {SubBrands XXX List Creation Start}
            if (MDD_Document.Types.Exist[xxxSubBrandListName])
            {
                MDD_Document.Types.Remove(xxxSubBrandListName);
            }

            IElements xxxSubBrands = MDD_Document.CreateElements(xxxSubBrandListName);
            MDD_Document.Types.Add(xxxSubBrands);

            xxxSubBrands.Reference = listSubBrands;
            xxxSubBrands.Namespace = false;
            xxxSubBrands.Inline = true;
            // {SubBrands XXX List Creation End}
        }

        public void ExportCountry_Q()
        {
            if (MDD_Document.Fields.Exist["COUNTRY_Q"])
            {
                MDD_Document.Fields.Remove("COUNTRY_Q");
            }

            IVariable country_Q = MDD_Document.CreateVariable("COUNTRY_Q");

            country_Q.DataType = DataTypeConstants.mtCategorical;
            country_Q.MinValue = 1;
            country_Q.MaxValue = 1;

            MDD_Document.Fields.Add(country_Q, 0);

            IElement category = MDD_Document.CreateElement( "_" + _brandlist.MarketCode.ToString());
            country_Q.Elements.Add(category);

            for (int i = 0; i < MDD_Document.Languages.Count; i++)
            {
                MDD_Document.Languages.Current = MDD_Document.Languages[i].Name;

                category.Label = _brandlist.Country;
                country_Q.Label = "Country";
            }

            var other = _brandlist.MainBrandList.First(x => x.BrandCode == "9997").TrackerCode;
            var none = _brandlist.MainBrandList.First(x => x.BrandCode == "9999").TrackerCode;
            var dontKnow = _brandlist.MainBrandList.First(x => x.BrandCode == "9998").TrackerCode;

            var rmcProducts = _brandlist.SubBrandList.Where(x => x.Type == Enums.ProductType.RMC).Select(x=>x.TrackerCode);
            var ryoProducts = _brandlist.SubBrandList.Where(x => x.Type == Enums.ProductType.RYO).Select(x => x.TrackerCode);
            var myoProducts = _brandlist.SubBrandList.Where(x => x.Type == Enums.ProductType.RYO).Select(x => x.TrackerCode);

            category.Properties["ShortName"] = _brandlist.CountryCode;
            category.Properties["SurveyLang"] = "";
            category.Properties["DayLimit"] = "1";
            category.Properties["WeekLimit"] = "7";
            category.Properties["StudyType"] = "{offline tablet}";
            category.Properties["OtherResponse"] = "{" + other + "}";
            category.Properties["NoneResponse"] = "{" + none + "}";
            category.Properties["DKResponse"] = "{" + dontKnow + "}";
            category.Properties["NoneDK"] = "{" + none + "," + dontKnow + "}";
            category.Properties["ProjectType"] = "{tracker}";
            category.Properties["ImagesLink"] = "";
            category.Properties["SharedAssetsLink"] = "";
            category.Properties["CurrentWave"] = _brandlist.CurrentWave;
            category.Properties["OtherResponses"] = "{" + string.Join(",", _brandlist.MainBrandList.First(x => x.BrandCode == "9997").SubBrandList.Select(x => x.TrackerCode)) + "}";
            category.Properties["RMC_Products"] = "{" + string.Join(",", rmcProducts) + "}";
            category.Properties["MYO_Products"] = "{" + string.Join(",", myoProducts) + "}";
            category.Properties["RYO_Products"] = "{" + string.Join(",", ryoProducts) + "}";
        }

        public void SaveAndOpen(MainUI ui)
        {

            var mddDirectory = _brandlist.MDDFullFileName.Substring(0, _brandlist.MDDFullFileName.Length - 4);

            MDD_Document.Save(Dir + _brandlist.MDDShortFileName);

            if (!mddDirectory.Contains("_Updated"))
            {
                mddDirectory += "_Updated";
            }

            try
            {
                MDD_Document.Save(mddDirectory + ".mdd");
            }
            catch
            {
                isSuccess = false;
            }

            MDD_Document.Close();

            if (!isSuccess)
            {
                MetroMessageBox.Show(ui, "This file is already open. Please close it and they again.", "File already open.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MetroMessageBox.Show(ui, "Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ui.Enabled = true;

            System.Diagnostics.Process.Start(_brandlist.MDDPath);
        }
    }
}
