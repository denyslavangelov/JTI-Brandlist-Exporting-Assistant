using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Brandlist_Export_Assistant.Forms;
using MetroFramework;

namespace Brandlist_Export_Assistant.Classes
{
    public class IFieldExport : Export
    {
        public IFieldExport(ExcelProcessor _brandlist) : base(_brandlist)
        {
        }

        public override string Dir => $@"C:\Users\{Environment.UserName}\Documents\Brandlist Export Assistant\{_brandlist.Country}\{_brandlist.FileName}\iFieldExport\";

        public override void _Export(MainUI ui)
        {
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }

            var brandList = @"Text" + "\t" + "ObjectName" + "\t" + "Extended Properties" + Environment.NewLine;
            var skuList = @"Text" + "\t" + "ObjectName" + Environment.NewLine;
            var skuListNoImage = @"Text" + "\t" + "ObjectName" + Environment.NewLine;


            foreach (var brand in _brandlist.MainBrandList)
            {
                brandList += brand.GlobalLabel + "\t" + brand.TrackerCode + "\t" + "{\"skuList:\" " + string.Join(",", brand.SubBrandList.Select(x => x.TrackerCode)) + "\"}" + Environment.NewLine;
            }

            foreach (var sku in _brandlist.SubBrandList)
            {
                skuList += "{#resource:\"" + sku.TrackerCode + ".jpg\",enlargeable:true,size:\"{#enImgSize#}%\"#}<br/>" + sku.GlobalLabel + "\t" + sku.TrackerCode + Environment.NewLine;
                skuListNoImage += sku.GlobalLabel + "\t" + sku.TrackerCode + Environment.NewLine;
            }

            File.WriteAllText(Path.Combine(Dir, "brandList.txt"), brandList);
            File.WriteAllText(Path.Combine(Dir, "skuList.txt"), skuList);
            File.WriteAllText(Path.Combine(Dir, "skuListNoImage.txt"), skuListNoImage);
            File.WriteAllText(Path.Combine(Dir, "translation.txt"), TranslationExport(ui));

            MetroMessageBox.Show(ui, "Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start(Dir);
        }

        public string TranslationExport(MainUI ui)
        {
            var translationExport = "";

            var localLanguage = "";
            var secondLocalLanguage = "";

            var languages = Countries.ExportLanguages();

            localLanguage = languages.Where(x => x.Value == ui.localLanguagesComboBox.Text).Select(x => x.Key).First() + " " + languages.Where(x => x.Value == ui.localLanguagesComboBox.Text).Select(x => x.Value).First();

            if (ui.iFieldSecondLocalLanguageCheckBox.Checked)
            {
                secondLocalLanguage = languages.Where(x => x.Value == ui.secondLocalLanguageComboBox.Text).Select(x => x.Key).First() + " " + languages.Where(x => x.Value == ui.secondLocalLanguageComboBox.Text).Select(x => x.Value).First();
            }

            translationExport += "Full Object Name" + "\t" + "Literal ID" + "\t" + localLanguage + "\t";

            if (ui.iFieldSecondLocalLanguageCheckBox.Checked)
            {
                translationExport += secondLocalLanguage + "\t";
            }

            translationExport += Environment.NewLine;

            translationExport += "--- Survey Literals ---" + "\t" + "--- Survey Literals ---" + "\t" + "--------------------";

            if (ui.iFieldSecondLocalLanguageCheckBox.Checked)
            {
                translationExport += "\t" + "--------------------";
            }

            translationExport += Environment.NewLine;

            foreach (var brand in _brandlist.MainBrandList)
            {
                translationExport += "brandList." + brand.TrackerCode + ".text" + "\t" + brand.GlobalLabel + "\t" + brand.LocalLabel + "\t";

                if (ui.iFieldSecondLocalLanguageCheckBox.Checked)
                {
                    translationExport += brand.SecondLocalLabel;
                }

                translationExport += Environment.NewLine;
            }

            foreach (var subBrand in _brandlist.SubBrandList)
            {
                translationExport += "skuList." + subBrand.TrackerCode + ".text" + "\t" + "{#resource:" + subBrand.TrackerCode + ".jpg,enlargeable:true,size:\"{#enImgSize#}%\"#}<br/>" + subBrand.GlobalLabel + "\t" + "{#resource:" + subBrand.TrackerCode + ".jpg,enlargeable:true,size:\"{#enImgSize#}%\"#}<br/>" + subBrand.LocalLabel + "\t";

                if (ui.iFieldSecondLocalLanguageCheckBox.Checked)
                {
                    translationExport += "{#resource:" + subBrand.TrackerCode + ".jpg,enlargeable:true,size:\"{#enImgSize#}%\"#}<br/>" + subBrand.SecondLocalLabel;
                }

                translationExport += Environment.NewLine;
            }

            foreach (var subBrand in _brandlist.SubBrandList)
            {
                translationExport += "skuListNoImage." + subBrand.TrackerCode + ".text" + "\t" + subBrand.GlobalLabel + "\t" + subBrand.LocalLabel + "\t";

                if (ui.iFieldSecondLocalLanguageCheckBox.Checked)
                {
                    translationExport += subBrand.SecondLocalLabel;
                }

                translationExport += Environment.NewLine;
            }


            return translationExport;
        }
    }
}
