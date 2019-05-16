using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Brandlist_Export_Assistant.Classes;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using Microsoft.Office.Interop.Excel;

namespace Brandlist_Export_Assistant.Forms
{
    public partial class MainUI
    {
        public MainUI() => InitializeComponent();

        private readonly ExcelProcessor _brandlist = new ExcelProcessor();

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog
            {
                Filter = @"Excel Files|*.xls;*.xlsx;*.xlsm"
            };

            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                browseButton.Hide();

                _brandlist.ExcelApp.Workbooks.Open(browseFile.FileName); // Open the excel file.

                _brandlist.ExcelData = CollectData(_brandlist.ExcelApp.ActiveSheet); // Collect all of the data from the active sheet.

                Validator.ValidateExcelData(_brandlist.ExcelData, this);

                _brandlist.SetColumnIndexes(_brandlist.ExcelData); // Locate and set the indexes of the needed columns.

                _brandlist.FileName = _brandlist.ExcelApp.ActiveWorkbook.Name;
               
                FillForm();

                metroLabel1.Visible = false;
                metroProgressBar1.Visible = false;

                // Animation
                while (this.Width < 740)
                {
                    this.Width += 18;
                    System.Windows.Forms.Application.DoEvents();
                }

                validationPanel.Show();
                validationPanelBtn.Show();
                validationPanelBtn.Select();

                excelLoadLabel.Show();
                excelLoadLabel.UseCustomForeColor = true;
                excelLoadLabel.ForeColor = Color.Green;
                excelLoadLabel.Text = @"Successfully loaded :" + Environment.NewLine + _brandlist.FileName;

                restartBtn.Show();

                _brandlist.ExcelApp.Quit(); // Close the excel file since we already collected the data from it and we don't need it.
            }
        }

        private Dictionary<Dictionary<int, string>, Dictionary<int, string[]>> CollectData(Worksheet worksheet)
        {
            var usedRange = worksheet.Range["A1", Type.Missing].CurrentRegion;
            var columnIndex = 0;

            var fullColumnData = new Dictionary<int, string>();
            var fullRowData = new Dictionary<int, string[]>();
            var wholeData = new Dictionary<Dictionary<int, string>, Dictionary<int, string[]>>();

            foreach (Range row in usedRange.Rows)
            {
                var columnData = new string[row.Columns.Count];

                for (var i = 0; i < row.Columns.Count; i++)
                {
                    columnData[i] = Convert.ToString(row.Cells[1, i + 1].Value2);

                    if (fullColumnData.Keys.Count < row.Columns.Count)
                    {
                        fullColumnData.Add(columnIndex, columnData[i]);
                        columnIndex++;
                    }
                }
                break;
            }

            var rangeColumn = fullColumnData.FirstOrDefault(x => x.Value == "Status").Key;
            var values = (object[,])usedRange.Value2;
            var rowsCount = values.GetLength(0);

            metroProgressBar1.Maximum = rowsCount;
            metroProgressBar1.Visible = true;
            metroLabel1.Visible = true;

            var rowIndex = 1;

            while (rowIndex < rowsCount)
            {
                var rowData = new string[rangeColumn + 1];

                for (int c = 1; c <= rangeColumn + 1; c++)
                {
                    rowData[c - 1] = Convert.ToString(values[rowIndex + 1, c]);
                }

                var percentComplete = (int)Math.Round((double)(100 * metroProgressBar1.Value) / metroProgressBar1.Maximum);
                metroLabel1.Text = $@"Loading: {percentComplete}%";

                Thread.Sleep(1);
                metroProgressBar1.Value += 1;

                System.Windows.Forms.Application.DoEvents();

                fullRowData.Add(rowIndex, rowData);
                rowIndex++;
            }

            metroLabel1.Text = @"Success.";
            metroLabel1.UseCustomForeColor = true;
            metroLabel1.ForeColor = Color.Green;

            wholeData.Add(fullColumnData, fullRowData);
            return wholeData;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            globalLabelBox.Enabled = false;
            trackerCodeBox.Enabled = false;
            localLabelBox.Enabled = false;

            confirmBtn.Enabled = false;

            excelLoadLabel.Hide();
            validationPanel.Hide();
            exportPanel.Hide();
            validationPanelBtn.Hide();
            exportPanelBtn.Hide();

            this.Width = 340;
            this.Height = 580;

            restartBtn.Hide();

            metroProgressBar1.Visible = false;
            metroLabel1.Visible = false;

            brandsBox.Items.Add("All");
            brandsBox.Text = brandsBox.Items[0].ToString();

            exportGroupBox.Visible = false;

            iFieldExportBtn.Visible = false;
            dimensionsExportBtn.Visible = false;

            dimensionsExportGroupBox.Width = 350;
            dimensionsExportGroupBox.Height = 210;
            dimensionsExportGroupBox.Visible = false;

            loadedMDDLabel.Visible = false;

            mddRestartBtn.Visible = false;

            secondLanguageLabel.Visible = false;
            secondLanguageBox.Visible = false;

            customPropertyLabel1.Visible = false;
            customPropertyBox.Visible = false;

            validationPanelBtn.Enabled = false;

            secondLocalLanguageComboBox.Visible = false;

            _brandlist.PopulateLanguages(this);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (EmptyColumns())
            {
                MetroMessageBox.Show(this, "There shouldn't be any empty column indicators.", "Empty Boxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _brandlist.PopulateBrands(this);

                exportGroupBox.Visible = true;

                validationPanel.Visible = false;
                validationPanelLabel.Visible = false;

                exportPanel.Visible = true;
                exportPanelBtn.Visible = true;
                exportPanelBtn.Select();
                
                globalLabelBox.Enabled = false;
                localLabelBox.Enabled = false;
                customPropertyBox.Enabled = false;
                secondLanguageBox.Enabled = false;

                foreach (var brand in _brandlist.MainBrandList)
                {
                    brandsBox.Items.Add(brand.GlobalLabel);
                }

                foreach (var sku in _brandlist.SubBrandList)
                {
                    skuBox.Items.Add(sku.GlobalLabel);
                }

                brandsCount.Text = $@"Count:{brandsBox.Items.Count}";
                skuCount.Text = $@"Count:{skuBox.Items.Count}";
            }
        }

        private void ExportPanelBtn_Click(object sender, EventArgs e)
        {
            validationPanel.Visible = false;
            exportPanel.Visible = true;
        }
         
        private void ValidationPanelBtn_Click(object sender, EventArgs e)
        {
            exportPanelBtn.Enabled = true;

            validationPanelBtn.Highlight = true;

            exportPanel.Visible = false;
            validationPanel.Visible = true; 
        }

        private void FillForm()
        {
            var headers = _brandlist.ExcelData.Keys.SelectMany(x => x.Values).ToArray();

            const string emptyColumn = "Please select a column.";

            var comboBoxes = new List<MetroComboBox>
            {
                sheetNameBox,
                trackerCodeBox,
                globalLabelBox,
                localLabelBox,
                customPropertyBox,
                secondLanguageBox
            };

            foreach (var column in headers)
            {
                if (column == null) continue;

                comboBoxes.ForEach(x=>x.Items.Add(column));
            }

            foreach (var box in comboBoxes)
            {
                box.PromptText = emptyColumn;
            }

            if (_brandlist.TrackerCodeColumnIndex != 0)
            {
                trackerCodeBox.Text = @"Tracker 2.0 Code";
            }

            if (_brandlist.GlobalLabelColumnIndex != 0)
            {
                globalLabelBox.Text = @"Label in English (Translated Questionnaire label)";
            }

            if (_brandlist.LocalLabelColumnIndex != 0)
            {
                this.localLabelBox.Text = @"Local Label in local language A (Questionnaire label)";
            }

            this.sheetNameBox.Items.Add(_brandlist.SheetName);
            this.sheetNameBox.Text = _brandlist.SheetName;

            trackerCodeBox.Enabled = false;
            sheetNameBox.Enabled = false;

            globalLabelBox.Enabled = true;
            localLabelBox.Enabled = true;
            confirmBtn.Enabled = true;
        }

        private bool EmptyColumns()
        {
            // {Method Description}: Loop through all of the boxes and check for empty columns.
            var emptyColumn = false;

            var comboBoxes = new List<MetroComboBox>
            {
                sheetNameBox,
                trackerCodeBox,
                globalLabelBox,
                localLabelBox,
                secondLanguageBox,
                customPropertyBox
            };

            foreach (var cmbBox in comboBoxes)
            {
                if (cmbBox.Text == "" && cmbBox.Visible == true)
                {
                    emptyColumn = true;
                    break;
                }
            }

            return emptyColumn;
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            RestartApp();
        }

        private void BrandsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            skuBox.Items.Clear();

            var skuList = _brandlist.MainBrandList.FirstOrDefault(x => x.GlobalLabel == brandsBox.Text)?.SubBrandList;

            if (brandsBox.Text == @"All")
            {
                foreach (var sku in _brandlist.SubBrandList)
                {
                    skuBox.Items.Add(sku.GlobalLabel);
                }
            }

            if (skuList != null && skuList.Count != 0)
            {
                foreach (var sku in skuList)
                {
                    skuBox.Items.Add(sku.GlobalLabel);
                }

                skuBox.Text = skuBox.Items[0].ToString();
            }

            

            brandsCount.Text = $@"Count:{brandsBox.Items.Count}";
            skuCount.Text = $@"Count:{skuBox.Items.Count}";
        }

        private void IFieldExportBtn_Click(object sender, EventArgs e)
        {
            var export = new IFieldExport(_brandlist);

            export._Export(this);
        }

        private void IFieldExportToggle_CheckedChanged(object sender, EventArgs e)
        {
            iFieldExportGroupBox.Visible = iFieldExportToggle.Checked;
            iFieldExportBtn.Visible = iFieldExportToggle.Checked;

            dimensionsExportToggle.Checked = false;
            dimensionsExportGroupBox.Visible = false;
        }

        private void DimensionsExportToggle_CheckedChanged(object sender, EventArgs e)
        {

            dimensionsExportGroupBox.Visible = dimensionsExportToggle.Checked;

            iFieldExportToggle.Checked = false;
            iFieldExportGroupBox.Visible = false;
        }

        private void BrowseMDDBtn_Click(object sender, EventArgs e)
        {
            var browseFile = new OpenFileDialog
            {
                Filter = @"MDD Files|*.mdd;"
            };

            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                mddRestartBtn.Visible = true;
                browseMDDBtn.Visible = false;
                dimensionsExportBtn.Visible = true;

                browseMDD_Label.Visible = false;

                loadedMDDLabel.Visible = true;
                //loadedMDDLabel.Text = @"Loaded: " + browseFile.SafeFileName;
                loadedMDDLabel.Text = "Loaded successfully.";
                loadedMDDLabel.UseCustomForeColor = true;
                loadedMDDLabel.ForeColor = Color.Green;

                _brandlist.MDDShortFileName = browseFile.SafeFileName;
                _brandlist.MDDFullFileName = browseFile.FileName;
                _brandlist.MDDPath = Path.GetDirectoryName(_brandlist.MDDFullFileName);
            }
        }

        public void mddRestartBtn_Click(object sender, EventArgs e)
        {
            mddRestartBtn.Visible = false;
            browseMDDBtn.Visible = true;
            browseMDD_Label.Visible = true;

            loadedMDDLabel.Visible = false;

            dimensionsExportBtn.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var pRed = new Pen(Color.Crimson);
            var pGreen = new Pen(Color.FromArgb(26, 211, 130));
            var g = e.Graphics;
            const int diff = 1;

            var comboBoxes = new List<MetroComboBox>
            {
                sheetNameBox,
                trackerCodeBox,
                globalLabelBox,
                localLabelBox,
                secondLanguageBox,
                customPropertyBox,
                localLanguagesComboBox
                
            };

            foreach (var box in comboBoxes)
            {
                if (box.Visible == true)
                {
                    if (box.Text == "")
                    {
                        g.DrawRectangle(pRed, new System.Drawing.Rectangle(box.Location.X - diff, box.Location.Y - diff, box.Width + diff, box.Height + diff));
                    }
                    else
                    {
                        g.DrawRectangle(pGreen, new System.Drawing.Rectangle(box.Location.X - diff, box.Location.Y - diff, box.Width + diff, box.Height + diff));
                    }
                }
            } 
        }

        private void globalLabelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void localLabelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        public void RestartApp()
        {
            _brandlist.ExcelApp.Quit();

            System.Windows.Forms.Application.Restart();
            Environment.Exit(0);
        }

        private void dimensionsExportBtn_Click(object sender, EventArgs e)
        {
            DimensionsExport dimensionsExport = new DimensionsExport(_brandlist);

            dimensionsExport._Export(this);
        }

        private void secondLocalLanguageLabel_CheckedChanged(object sender, EventArgs e)
        {
            secondLanguageLabel.Visible = secondLocalLanguageCheckBox.Checked ? true : false;
            secondLanguageBox.Visible = secondLocalLanguageCheckBox.Checked ? true : false;

            this.Refresh();
        }

        private void customPropertyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            customPropertyLabel1.Visible = customPropertyCheckBox.Checked ? true : false;
            customPropertyBox.Visible = customPropertyCheckBox.Checked ? true : false;

            this.Refresh();
        }

        private void secondLanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void customPropertyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void iFieldSecondLocalLanguageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            secondLocalLanguageComboBox.Visible = iFieldSecondLocalLanguageCheckBox.Checked ? true : false;
        }
    }
}
