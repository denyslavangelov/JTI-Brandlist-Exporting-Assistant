using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brandlist_Export_Assistant.Forms;
using MDMLib;
using MetroFramework;

namespace Brandlist_Export_Assistant.Classes
{
    public static class Validator
    {

        public static void ValidateBrand(Brand brand, int rowIndex, MainUI UI)
        {
            var validBrand = true;

            if (string.IsNullOrEmpty(brand.TrackerCode) || brand.TrackerCode == "br_")
            {
                MetroMessageBox.Show(UI, $"There is an invalid tracker code at row {rowIndex}.", "Invalid Tracker Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validBrand = false;
            }

            if (string.IsNullOrEmpty(brand.GlobalLabel) || brand.GlobalLabel == "n/a")
            {
                MetroMessageBox.Show(UI, $"There is an invalid global label at row {rowIndex}.", "Invalid Global Label", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validBrand = false;
            }

            if (string.IsNullOrEmpty(brand.LocalLabel) || brand.LocalLabel == "n/a")
            {
                MetroMessageBox.Show(UI, $"There is an invalid local label at row {rowIndex}.", "Invalid Local Label", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validBrand = false;
            }

            if (!validBrand)
            {
                UI.RestartApp();
            }
        }

        public static void Validate_HasMainBrand(List<SubBrand> subBrandList, MainUI UI)
        {

            foreach (var subBrand in subBrandList)
            {
                if (!subBrand.HasMainBrand)
                {
                    MetroMessageBox.Show(UI, $"The sub brand named {subBrand.GlobalLabel} doesn't have a main brand.", "No Main Brand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UI.RestartApp();
                }
            }
        }

        public static void Validate_HasSubBrandList(List<MainBrand> mainBrandList, MainUI UI)
        {
            for (var i = 0; i < mainBrandList.Count - 3; i++)
            {
                if (!mainBrandList[i].HasAnySubBrands)
                {
                    MetroMessageBox.Show(UI, $"The brand named {mainBrandList[i].GlobalLabel} doesn't have any sub brands.", "No Main Brand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UI.RestartApp();
                }
            }
        }

        public static void ValidateExcelData(Dictionary<Dictionary<int, string>, Dictionary<int, string[]>> excelData, MainUI UI)
        {
            if (excelData.Keys.SelectMany(x=>x.Keys).Count() < 10 || excelData.Keys.SelectMany(x => x.Values).Count() < 10)
            {
                MetroMessageBox.Show(UI, $"It seems like you've loaded an invalid brandlist file.", "Invalid brandlist.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UI.RestartApp();
            }
        }

        public static void CheckIfAlreadyOpen(Document document, DimensionsExport export, MainUI ui)
        {

        }
    }
}
