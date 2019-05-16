namespace Brandlist_Export_Assistant.Forms
{
    partial class MainUI : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.trackerCodeBox = new MetroFramework.Controls.MetroComboBox();
            this.localLabelBox = new MetroFramework.Controls.MetroComboBox();
            this.confirmBtn = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.validationPanel = new System.Windows.Forms.Panel();
            this.customPropertyLabel1 = new System.Windows.Forms.Label();
            this.customPropertyBox = new MetroFramework.Controls.MetroComboBox();
            this.secondLanguageLabel = new System.Windows.Forms.Label();
            this.secondLanguageBox = new MetroFramework.Controls.MetroComboBox();
            this.customPropertyCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.secondLocalLanguageCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.validationPanelLabel = new MetroFramework.Controls.MetroLabel();
            this.globalLabelBox = new MetroFramework.Controls.MetroComboBox();
            this.sheetNameBox = new MetroFramework.Controls.MetroComboBox();
            this.exportPanel = new MetroFramework.Controls.MetroPanel();
            this.iFieldExportToggle = new MetroFramework.Controls.MetroToggle();
            this.brandsLabel = new MetroFramework.Controls.MetroLabel();
            this.skusLabel = new MetroFramework.Controls.MetroLabel();
            this.iFieldExportGroupBox = new System.Windows.Forms.GroupBox();
            this.languagesGroupBox = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.localLanguagesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.iFieldSecondLocalLanguageCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.secondLocalLanguageComboBox = new MetroFramework.Controls.MetroComboBox();
            this.iFieldExportBtn = new MetroFramework.Controls.MetroButton();
            this.skuBox = new MetroFramework.Controls.MetroComboBox();
            this.dimensionsExportToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.iFieldExportLabel = new MetroFramework.Controls.MetroLabel();
            this.brandsBox = new MetroFramework.Controls.MetroComboBox();
            this.informationalLabel = new MetroFramework.Controls.MetroLabel();
            this.exportGroupBox = new System.Windows.Forms.GroupBox();
            this.skuCount = new System.Windows.Forms.Label();
            this.brandsCount = new System.Windows.Forms.Label();
            this.dimensionsExportGroupBox = new System.Windows.Forms.GroupBox();
            this.dimensionsExportBtn = new MetroFramework.Controls.MetroButton();
            this.loadedMDDLabel = new MetroFramework.Controls.MetroLabel();
            this.browseMDD_Label = new MetroFramework.Controls.MetroLabel();
            this.browseMDDBtn = new MetroFramework.Controls.MetroButton();
            this.mddRestartBtn = new MetroFramework.Controls.MetroButton();
            this.restartBtn = new MetroFramework.Controls.MetroButton();
            this.excelLoadLabel = new MetroFramework.Controls.MetroLabel();
            this.browseButton = new MetroFramework.Controls.MetroButton();
            this.exportPanelBtn = new MetroFramework.Controls.MetroButton();
            this.validationPanelBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.validationPanel.SuspendLayout();
            this.exportPanel.SuspendLayout();
            this.iFieldExportGroupBox.SuspendLayout();
            this.languagesGroupBox.SuspendLayout();
            this.exportGroupBox.SuspendLayout();
            this.dimensionsExportGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackerCodeBox
            // 
            this.trackerCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackerCodeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trackerCodeBox.FormattingEnabled = true;
            this.trackerCodeBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trackerCodeBox.ItemHeight = 23;
            this.trackerCodeBox.Location = new System.Drawing.Point(17, 95);
            this.trackerCodeBox.Name = "trackerCodeBox";
            this.trackerCodeBox.Size = new System.Drawing.Size(324, 29);
            this.trackerCodeBox.TabIndex = 2;
            this.trackerCodeBox.TabStop = false;
            this.trackerCodeBox.UseCustomBackColor = true;
            this.trackerCodeBox.UseCustomForeColor = true;
            this.trackerCodeBox.UseSelectable = true;
            this.trackerCodeBox.UseStyleColors = true;
            // 
            // localLabelBox
            // 
            this.localLabelBox.FormattingEnabled = true;
            this.localLabelBox.ItemHeight = 23;
            this.localLabelBox.Location = new System.Drawing.Point(17, 249);
            this.localLabelBox.Name = "localLabelBox";
            this.localLabelBox.Size = new System.Drawing.Size(324, 29);
            this.localLabelBox.TabIndex = 4;
            this.localLabelBox.TabStop = false;
            this.localLabelBox.UseSelectable = true;
            this.localLabelBox.SelectedIndexChanged += new System.EventHandler(this.localLabelBox_SelectedIndexChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Highlight = true;
            this.confirmBtn.Location = new System.Drawing.Point(202, 434);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(139, 30);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.TabStop = false;
            this.confirmBtn.Text = "Next";
            this.confirmBtn.UseSelectable = true;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tracker Code Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Global Label Column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Local Label Column";
            // 
            // validationPanel
            // 
            this.validationPanel.BackColor = System.Drawing.Color.White;
            this.validationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.validationPanel.Controls.Add(this.customPropertyLabel1);
            this.validationPanel.Controls.Add(this.customPropertyBox);
            this.validationPanel.Controls.Add(this.secondLanguageLabel);
            this.validationPanel.Controls.Add(this.secondLanguageBox);
            this.validationPanel.Controls.Add(this.customPropertyCheckBox);
            this.validationPanel.Controls.Add(this.secondLocalLanguageCheckBox);
            this.validationPanel.Controls.Add(this.label6);
            this.validationPanel.Controls.Add(this.validationPanelLabel);
            this.validationPanel.Controls.Add(this.globalLabelBox);
            this.validationPanel.Controls.Add(this.confirmBtn);
            this.validationPanel.Controls.Add(this.label3);
            this.validationPanel.Controls.Add(this.label2);
            this.validationPanel.Controls.Add(this.label1);
            this.validationPanel.Controls.Add(this.localLabelBox);
            this.validationPanel.Controls.Add(this.trackerCodeBox);
            this.validationPanel.Controls.Add(this.sheetNameBox);
            this.validationPanel.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.validationPanel.Location = new System.Drawing.Point(358, 78);
            this.validationPanel.Name = "validationPanel";
            this.validationPanel.Size = new System.Drawing.Size(361, 475);
            this.validationPanel.TabIndex = 15;
            this.validationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customPropertyLabel1
            // 
            this.customPropertyLabel1.AutoSize = true;
            this.customPropertyLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customPropertyLabel1.Location = new System.Drawing.Point(14, 361);
            this.customPropertyLabel1.Name = "customPropertyLabel1";
            this.customPropertyLabel1.Size = new System.Drawing.Size(172, 17);
            this.customPropertyLabel1.TabIndex = 26;
            this.customPropertyLabel1.Text = "Custom Property Column";
            // 
            // customPropertyBox
            // 
            this.customPropertyBox.FormattingEnabled = true;
            this.customPropertyBox.ItemHeight = 23;
            this.customPropertyBox.Location = new System.Drawing.Point(17, 381);
            this.customPropertyBox.Name = "customPropertyBox";
            this.customPropertyBox.Size = new System.Drawing.Size(324, 29);
            this.customPropertyBox.TabIndex = 25;
            this.customPropertyBox.TabStop = false;
            this.customPropertyBox.UseSelectable = true;
            this.customPropertyBox.SelectedIndexChanged += new System.EventHandler(this.customPropertyBox_SelectedIndexChanged);
            // 
            // secondLanguageLabel
            // 
            this.secondLanguageLabel.AutoSize = true;
            this.secondLanguageLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondLanguageLabel.Location = new System.Drawing.Point(14, 296);
            this.secondLanguageLabel.Name = "secondLanguageLabel";
            this.secondLanguageLabel.Size = new System.Drawing.Size(190, 17);
            this.secondLanguageLabel.TabIndex = 24;
            this.secondLanguageLabel.Text = "Second Local Label Column";
            // 
            // secondLanguageBox
            // 
            this.secondLanguageBox.FormattingEnabled = true;
            this.secondLanguageBox.ItemHeight = 23;
            this.secondLanguageBox.Location = new System.Drawing.Point(17, 316);
            this.secondLanguageBox.Name = "secondLanguageBox";
            this.secondLanguageBox.Size = new System.Drawing.Size(324, 29);
            this.secondLanguageBox.TabIndex = 23;
            this.secondLanguageBox.TabStop = false;
            this.secondLanguageBox.UseSelectable = true;
            this.secondLanguageBox.SelectedIndexChanged += new System.EventHandler(this.secondLanguageBox_SelectedIndexChanged);
            // 
            // customPropertyCheckBox
            // 
            this.customPropertyCheckBox.AutoSize = true;
            this.customPropertyCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customPropertyCheckBox.Location = new System.Drawing.Point(17, 451);
            this.customPropertyCheckBox.Name = "customPropertyCheckBox";
            this.customPropertyCheckBox.Size = new System.Drawing.Size(156, 15);
            this.customPropertyCheckBox.TabIndex = 22;
            this.customPropertyCheckBox.Text = "Export a custom property";
            this.customPropertyCheckBox.UseSelectable = true;
            this.customPropertyCheckBox.CheckedChanged += new System.EventHandler(this.customPropertyCheckBox_CheckedChanged);
            // 
            // secondLocalLanguageCheckBox
            // 
            this.secondLocalLanguageCheckBox.AutoSize = true;
            this.secondLocalLanguageCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondLocalLanguageCheckBox.Location = new System.Drawing.Point(17, 430);
            this.secondLocalLanguageCheckBox.Name = "secondLocalLanguageCheckBox";
            this.secondLocalLanguageCheckBox.Size = new System.Drawing.Size(166, 15);
            this.secondLocalLanguageCheckBox.TabIndex = 21;
            this.secondLocalLanguageCheckBox.Text = "Add second local language";
            this.secondLocalLanguageCheckBox.UseSelectable = true;
            this.secondLocalLanguageCheckBox.CheckedChanged += new System.EventHandler(this.secondLocalLanguageLabel_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sheet Name";
            // 
            // validationPanelLabel
            // 
            this.validationPanelLabel.AutoSize = true;
            this.validationPanelLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.validationPanelLabel.Location = new System.Drawing.Point(45, 134);
            this.validationPanelLabel.Name = "validationPanelLabel";
            this.validationPanelLabel.Size = new System.Drawing.Size(282, 19);
            this.validationPanelLabel.TabIndex = 18;
            this.validationPanelLabel.Text = "Please indicate the appropriate columns.";
            // 
            // globalLabelBox
            // 
            this.globalLabelBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.globalLabelBox.FormattingEnabled = true;
            this.globalLabelBox.ItemHeight = 23;
            this.globalLabelBox.Location = new System.Drawing.Point(17, 185);
            this.globalLabelBox.Name = "globalLabelBox";
            this.globalLabelBox.Size = new System.Drawing.Size(324, 29);
            this.globalLabelBox.TabIndex = 17;
            this.globalLabelBox.TabStop = false;
            this.globalLabelBox.UseSelectable = true;
            this.globalLabelBox.SelectedIndexChanged += new System.EventHandler(this.globalLabelBox_SelectedIndexChanged);
            // 
            // sheetNameBox
            // 
            this.sheetNameBox.FormattingEnabled = true;
            this.sheetNameBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sheetNameBox.ItemHeight = 23;
            this.sheetNameBox.Location = new System.Drawing.Point(17, 36);
            this.sheetNameBox.Name = "sheetNameBox";
            this.sheetNameBox.Size = new System.Drawing.Size(324, 29);
            this.sheetNameBox.TabIndex = 20;
            this.sheetNameBox.TabStop = false;
            this.sheetNameBox.UseSelectable = true;
            // 
            // exportPanel
            // 
            this.exportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exportPanel.Controls.Add(this.iFieldExportGroupBox);
            this.exportPanel.Controls.Add(this.iFieldExportToggle);
            this.exportPanel.Controls.Add(this.brandsLabel);
            this.exportPanel.Controls.Add(this.skusLabel);
            this.exportPanel.Controls.Add(this.skuBox);
            this.exportPanel.Controls.Add(this.dimensionsExportToggle);
            this.exportPanel.Controls.Add(this.metroLabel2);
            this.exportPanel.Controls.Add(this.iFieldExportLabel);
            this.exportPanel.Controls.Add(this.brandsBox);
            this.exportPanel.Controls.Add(this.informationalLabel);
            this.exportPanel.Controls.Add(this.exportGroupBox);
            this.exportPanel.Controls.Add(this.dimensionsExportGroupBox);
            this.exportPanel.HorizontalScrollbarBarColor = true;
            this.exportPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.exportPanel.HorizontalScrollbarSize = 10;
            this.exportPanel.Location = new System.Drawing.Point(354, 82);
            this.exportPanel.Name = "exportPanel";
            this.exportPanel.Size = new System.Drawing.Size(363, 475);
            this.exportPanel.TabIndex = 31;
            this.exportPanel.VerticalScrollbarBarColor = true;
            this.exportPanel.VerticalScrollbarHighlightOnWheel = false;
            this.exportPanel.VerticalScrollbarSize = 10;
            // 
            // iFieldExportToggle
            // 
            this.iFieldExportToggle.AutoSize = true;
            this.iFieldExportToggle.Location = new System.Drawing.Point(25, 215);
            this.iFieldExportToggle.Name = "iFieldExportToggle";
            this.iFieldExportToggle.Size = new System.Drawing.Size(80, 17);
            this.iFieldExportToggle.TabIndex = 7;
            this.iFieldExportToggle.Text = "Off";
            this.iFieldExportToggle.UseSelectable = true;
            this.iFieldExportToggle.CheckedChanged += new System.EventHandler(this.IFieldExportToggle_CheckedChanged);
            // 
            // brandsLabel
            // 
            this.brandsLabel.AutoSize = true;
            this.brandsLabel.Location = new System.Drawing.Point(23, 36);
            this.brandsLabel.Name = "brandsLabel";
            this.brandsLabel.Size = new System.Drawing.Size(49, 19);
            this.brandsLabel.TabIndex = 3;
            this.brandsLabel.Text = "Brands";
            // 
            // skusLabel
            // 
            this.skusLabel.AutoSize = true;
            this.skusLabel.Location = new System.Drawing.Point(16, 104);
            this.skusLabel.Name = "skusLabel";
            this.skusLabel.Size = new System.Drawing.Size(37, 19);
            this.skusLabel.TabIndex = 5;
            this.skusLabel.Text = "SKUs";
            // 
            // iFieldExportGroupBox
            // 
            this.iFieldExportGroupBox.Controls.Add(this.languagesGroupBox);
            this.iFieldExportGroupBox.Controls.Add(this.iFieldExportBtn);
            this.iFieldExportGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iFieldExportGroupBox.Location = new System.Drawing.Point(12, 249);
            this.iFieldExportGroupBox.Name = "iFieldExportGroupBox";
            this.iFieldExportGroupBox.Size = new System.Drawing.Size(349, 204);
            this.iFieldExportGroupBox.TabIndex = 10;
            this.iFieldExportGroupBox.TabStop = false;
            this.iFieldExportGroupBox.Text = "iField Export";
            this.iFieldExportGroupBox.Visible = false;
            // 
            // languagesGroupBox
            // 
            this.languagesGroupBox.Controls.Add(this.metroLabel3);
            this.languagesGroupBox.Controls.Add(this.localLanguagesComboBox);
            this.languagesGroupBox.Controls.Add(this.iFieldSecondLocalLanguageCheckBox);
            this.languagesGroupBox.Controls.Add(this.secondLocalLanguageComboBox);
            this.languagesGroupBox.Location = new System.Drawing.Point(10, 22);
            this.languagesGroupBox.Name = "languagesGroupBox";
            this.languagesGroupBox.Size = new System.Drawing.Size(330, 147);
            this.languagesGroupBox.TabIndex = 13;
            this.languagesGroupBox.TabStop = false;
            this.languagesGroupBox.Text = "Languages";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(96, 21);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(134, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Add a local language";
            // 
            // localLanguagesComboBox
            // 
            this.localLanguagesComboBox.FormattingEnabled = true;
            this.localLanguagesComboBox.ItemHeight = 23;
            this.localLanguagesComboBox.Location = new System.Drawing.Point(66, 45);
            this.localLanguagesComboBox.Name = "localLanguagesComboBox";
            this.localLanguagesComboBox.Size = new System.Drawing.Size(201, 29);
            this.localLanguagesComboBox.TabIndex = 11;
            this.localLanguagesComboBox.UseSelectable = true;
            // 
            // iFieldSecondLocalLanguageCheckBox
            // 
            this.iFieldSecondLocalLanguageCheckBox.AutoSize = true;
            this.iFieldSecondLocalLanguageCheckBox.Location = new System.Drawing.Point(83, 82);
            this.iFieldSecondLocalLanguageCheckBox.Name = "iFieldSecondLocalLanguageCheckBox";
            this.iFieldSecondLocalLanguageCheckBox.Size = new System.Drawing.Size(173, 15);
            this.iFieldSecondLocalLanguageCheckBox.TabIndex = 10;
            this.iFieldSecondLocalLanguageCheckBox.Text = "Add Second Local Language";
            this.iFieldSecondLocalLanguageCheckBox.UseSelectable = true;
            this.iFieldSecondLocalLanguageCheckBox.CheckedChanged += new System.EventHandler(this.iFieldSecondLocalLanguageCheckBox_CheckedChanged);
            // 
            // secondLocalLanguageComboBox
            // 
            this.secondLocalLanguageComboBox.FormattingEnabled = true;
            this.secondLocalLanguageComboBox.ItemHeight = 23;
            this.secondLocalLanguageComboBox.Location = new System.Drawing.Point(66, 103);
            this.secondLocalLanguageComboBox.Name = "secondLocalLanguageComboBox";
            this.secondLocalLanguageComboBox.Size = new System.Drawing.Size(201, 29);
            this.secondLocalLanguageComboBox.TabIndex = 12;
            this.secondLocalLanguageComboBox.UseSelectable = true;
            // 
            // iFieldExportBtn
            // 
            this.iFieldExportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iFieldExportBtn.Location = new System.Drawing.Point(127, 172);
            this.iFieldExportBtn.Name = "iFieldExportBtn";
            this.iFieldExportBtn.Size = new System.Drawing.Size(79, 23);
            this.iFieldExportBtn.TabIndex = 8;
            this.iFieldExportBtn.TabStop = false;
            this.iFieldExportBtn.Text = "iField Export";
            this.iFieldExportBtn.UseSelectable = true;
            this.iFieldExportBtn.Click += new System.EventHandler(this.IFieldExportBtn_Click);
            // 
            // skuBox
            // 
            this.skuBox.FormattingEnabled = true;
            this.skuBox.ItemHeight = 23;
            this.skuBox.Location = new System.Drawing.Point(23, 124);
            this.skuBox.Name = "skuBox";
            this.skuBox.Size = new System.Drawing.Size(321, 29);
            this.skuBox.TabIndex = 4;
            this.skuBox.TabStop = false;
            this.skuBox.UseSelectable = true;
            // 
            // dimensionsExportToggle
            // 
            this.dimensionsExportToggle.AutoSize = true;
            this.dimensionsExportToggle.Location = new System.Drawing.Point(239, 215);
            this.dimensionsExportToggle.Name = "dimensionsExportToggle";
            this.dimensionsExportToggle.Size = new System.Drawing.Size(80, 17);
            this.dimensionsExportToggle.TabIndex = 12;
            this.dimensionsExportToggle.Text = "Off";
            this.dimensionsExportToggle.UseSelectable = true;
            this.dimensionsExportToggle.CheckedChanged += new System.EventHandler(this.DimensionsExportToggle_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(225, 193);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Dimensions Export";
            // 
            // iFieldExportLabel
            // 
            this.iFieldExportLabel.AutoSize = true;
            this.iFieldExportLabel.Location = new System.Drawing.Point(23, 188);
            this.iFieldExportLabel.Name = "iFieldExportLabel";
            this.iFieldExportLabel.Size = new System.Drawing.Size(82, 19);
            this.iFieldExportLabel.TabIndex = 13;
            this.iFieldExportLabel.Text = "iField Export";
            // 
            // brandsBox
            // 
            this.brandsBox.FormattingEnabled = true;
            this.brandsBox.ItemHeight = 23;
            this.brandsBox.Location = new System.Drawing.Point(23, 58);
            this.brandsBox.Name = "brandsBox";
            this.brandsBox.Size = new System.Drawing.Size(321, 29);
            this.brandsBox.TabIndex = 2;
            this.brandsBox.TabStop = false;
            this.brandsBox.UseSelectable = true;
            this.brandsBox.SelectedIndexChanged += new System.EventHandler(this.BrandsBox_SelectedIndexChanged);
            // 
            // informationalLabel
            // 
            this.informationalLabel.AutoSize = true;
            this.informationalLabel.Location = new System.Drawing.Point(16, 3);
            this.informationalLabel.Name = "informationalLabel";
            this.informationalLabel.Size = new System.Drawing.Size(0, 0);
            this.informationalLabel.TabIndex = 6;
            // 
            // exportGroupBox
            // 
            this.exportGroupBox.Controls.Add(this.skuCount);
            this.exportGroupBox.Controls.Add(this.brandsCount);
            this.exportGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportGroupBox.Location = new System.Drawing.Point(10, 16);
            this.exportGroupBox.Name = "exportGroupBox";
            this.exportGroupBox.Size = new System.Drawing.Size(349, 150);
            this.exportGroupBox.TabIndex = 9;
            this.exportGroupBox.TabStop = false;
            this.exportGroupBox.Text = "For informational purposes only.";
            // 
            // skuCount
            // 
            this.skuCount.AutoSize = true;
            this.skuCount.Location = new System.Drawing.Point(261, 88);
            this.skuCount.Name = "skuCount";
            this.skuCount.Size = new System.Drawing.Size(57, 17);
            this.skuCount.TabIndex = 1;
            this.skuCount.Text = "Count: ";
            // 
            // brandsCount
            // 
            this.brandsCount.AutoSize = true;
            this.brandsCount.Location = new System.Drawing.Point(261, 22);
            this.brandsCount.Name = "brandsCount";
            this.brandsCount.Size = new System.Drawing.Size(57, 17);
            this.brandsCount.TabIndex = 0;
            this.brandsCount.Text = "Count: ";
            // 
            // dimensionsExportGroupBox
            // 
            this.dimensionsExportGroupBox.Controls.Add(this.dimensionsExportBtn);
            this.dimensionsExportGroupBox.Controls.Add(this.loadedMDDLabel);
            this.dimensionsExportGroupBox.Controls.Add(this.browseMDD_Label);
            this.dimensionsExportGroupBox.Controls.Add(this.browseMDDBtn);
            this.dimensionsExportGroupBox.Controls.Add(this.mddRestartBtn);
            this.dimensionsExportGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dimensionsExportGroupBox.Location = new System.Drawing.Point(6, 249);
            this.dimensionsExportGroupBox.Name = "dimensionsExportGroupBox";
            this.dimensionsExportGroupBox.Size = new System.Drawing.Size(350, 210);
            this.dimensionsExportGroupBox.TabIndex = 11;
            this.dimensionsExportGroupBox.TabStop = false;
            this.dimensionsExportGroupBox.Text = "Dimensions Export";
            this.dimensionsExportGroupBox.Visible = false;
            // 
            // dimensionsExportBtn
            // 
            this.dimensionsExportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dimensionsExportBtn.Location = new System.Drawing.Point(110, 169);
            this.dimensionsExportBtn.Name = "dimensionsExportBtn";
            this.dimensionsExportBtn.Size = new System.Drawing.Size(128, 23);
            this.dimensionsExportBtn.TabIndex = 12;
            this.dimensionsExportBtn.TabStop = false;
            this.dimensionsExportBtn.Text = "Import brandlist";
            this.dimensionsExportBtn.UseSelectable = true;
            this.dimensionsExportBtn.Click += new System.EventHandler(this.dimensionsExportBtn_Click);
            // 
            // loadedMDDLabel
            // 
            this.loadedMDDLabel.AutoSize = true;
            this.loadedMDDLabel.Location = new System.Drawing.Point(113, 144);
            this.loadedMDDLabel.Name = "loadedMDDLabel";
            this.loadedMDDLabel.Size = new System.Drawing.Size(154, 19);
            this.loadedMDDLabel.TabIndex = 15;
            this.loadedMDDLabel.Text = "Loaded: S19010541.mdd";
            // 
            // browseMDD_Label
            // 
            this.browseMDD_Label.AutoSize = true;
            this.browseMDD_Label.Location = new System.Drawing.Point(94, 80);
            this.browseMDD_Label.Name = "browseMDD_Label";
            this.browseMDD_Label.Size = new System.Drawing.Size(168, 19);
            this.browseMDD_Label.TabIndex = 14;
            this.browseMDD_Label.Text = "Please select your mdd file.";
            // 
            // browseMDDBtn
            // 
            this.browseMDDBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseMDDBtn.Location = new System.Drawing.Point(109, 105);
            this.browseMDDBtn.Name = "browseMDDBtn";
            this.browseMDDBtn.Size = new System.Drawing.Size(128, 23);
            this.browseMDDBtn.TabIndex = 13;
            this.browseMDDBtn.TabStop = false;
            this.browseMDDBtn.Text = "Browse";
            this.browseMDDBtn.UseSelectable = true;
            this.browseMDDBtn.Click += new System.EventHandler(this.BrowseMDDBtn_Click);
            // 
            // mddRestartBtn
            // 
            this.mddRestartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mddRestartBtn.Location = new System.Drawing.Point(279, 16);
            this.mddRestartBtn.Name = "mddRestartBtn";
            this.mddRestartBtn.Size = new System.Drawing.Size(62, 17);
            this.mddRestartBtn.TabIndex = 16;
            this.mddRestartBtn.TabStop = false;
            this.mddRestartBtn.Text = "Restart";
            this.mddRestartBtn.UseSelectable = true;
            this.mddRestartBtn.Click += new System.EventHandler(this.mddRestartBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartBtn.Highlight = true;
            this.restartBtn.Location = new System.Drawing.Point(502, 13);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(82, 20);
            this.restartBtn.TabIndex = 25;
            this.restartBtn.TabStop = false;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseSelectable = true;
            this.restartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // excelLoadLabel
            // 
            this.excelLoadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.excelLoadLabel.BackColor = System.Drawing.Color.White;
            this.excelLoadLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.excelLoadLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excelLoadLabel.Location = new System.Drawing.Point(392, 36);
            this.excelLoadLabel.Name = "excelLoadLabel";
            this.excelLoadLabel.Size = new System.Drawing.Size(301, 43);
            this.excelLoadLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.excelLoadLabel.TabIndex = 23;
            this.excelLoadLabel.Text = "Succesfully loaded:";
            this.excelLoadLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.excelLoadLabel.UseStyleColors = true;
            // 
            // browseButton
            // 
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton.DisplayFocus = true;
            this.browseButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.browseButton.Highlight = true;
            this.browseButton.Location = new System.Drawing.Point(31, 82);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(282, 72);
            this.browseButton.TabIndex = 20;
            this.browseButton.TabStop = false;
            this.browseButton.Text = "Load Brandlist";
            this.browseButton.UseSelectable = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // exportPanelBtn
            // 
            this.exportPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportPanelBtn.Highlight = true;
            this.exportPanelBtn.Location = new System.Drawing.Point(107, 242);
            this.exportPanelBtn.Name = "exportPanelBtn";
            this.exportPanelBtn.Size = new System.Drawing.Size(152, 53);
            this.exportPanelBtn.TabIndex = 21;
            this.exportPanelBtn.TabStop = false;
            this.exportPanelBtn.Text = "Export\r\n(Dimensions/iField)";
            this.exportPanelBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.exportPanelBtn.UseSelectable = true;
            this.exportPanelBtn.Click += new System.EventHandler(this.ExportPanelBtn_Click);
            // 
            // validationPanelBtn
            // 
            this.validationPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validationPanelBtn.Highlight = true;
            this.validationPanelBtn.Location = new System.Drawing.Point(107, 179);
            this.validationPanelBtn.Name = "validationPanelBtn";
            this.validationPanelBtn.Size = new System.Drawing.Size(152, 53);
            this.validationPanelBtn.TabIndex = 22;
            this.validationPanelBtn.TabStop = false;
            this.validationPanelBtn.Text = "Column\r\nSelection";
            this.validationPanelBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.validationPanelBtn.UseSelectable = true;
            this.validationPanelBtn.Click += new System.EventHandler(this.ValidationPanelBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(31, 328);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.metroProgressBar1.Size = new System.Drawing.Size(282, 23);
            this.metroProgressBar1.TabIndex = 29;
            this.metroProgressBar1.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 306);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Loading:  0%";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(741, 580);
            this.Controls.Add(this.validationPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.excelLoadLabel);
            this.Controls.Add(this.validationPanelBtn);
            this.Controls.Add(this.exportPanelBtn);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.exportPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Brandlist Exporting Assistant";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.validationPanel.ResumeLayout(false);
            this.validationPanel.PerformLayout();
            this.exportPanel.ResumeLayout(false);
            this.exportPanel.PerformLayout();
            this.iFieldExportGroupBox.ResumeLayout(false);
            this.languagesGroupBox.ResumeLayout(false);
            this.languagesGroupBox.PerformLayout();
            this.exportGroupBox.ResumeLayout(false);
            this.exportGroupBox.PerformLayout();
            this.dimensionsExportGroupBox.ResumeLayout(false);
            this.dimensionsExportGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroComboBox globalLabelBox;
        public MetroFramework.Controls.MetroComboBox trackerCodeBox;
        public MetroFramework.Controls.MetroComboBox localLabelBox;
        private MetroFramework.Controls.MetroButton confirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel validationPanel;
        private MetroFramework.Controls.MetroButton browseButton;
        private MetroFramework.Controls.MetroButton exportPanelBtn;
        private MetroFramework.Controls.MetroButton validationPanelBtn;
        private MetroFramework.Controls.MetroLabel excelLoadLabel;
        private MetroFramework.Controls.MetroLabel validationPanelLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroComboBox sheetNameBox;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton restartBtn;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel exportPanel;
        private MetroFramework.Controls.MetroLabel skusLabel;
        private MetroFramework.Controls.MetroComboBox skuBox;
        private MetroFramework.Controls.MetroLabel brandsLabel;
        private MetroFramework.Controls.MetroComboBox brandsBox;
        private MetroFramework.Controls.MetroButton iFieldExportBtn;
        private MetroFramework.Controls.MetroToggle iFieldExportToggle;
        private MetroFramework.Controls.MetroLabel informationalLabel;
        private System.Windows.Forms.GroupBox exportGroupBox;
        private System.Windows.Forms.GroupBox dimensionsExportGroupBox;
        private MetroFramework.Controls.MetroButton dimensionsExportBtn;
        private MetroFramework.Controls.MetroToggle dimensionsExportToggle;
        private System.Windows.Forms.GroupBox iFieldExportGroupBox;
        private System.Windows.Forms.Label skuCount;
        private System.Windows.Forms.Label brandsCount;
        private MetroFramework.Controls.MetroLabel browseMDD_Label;
        private MetroFramework.Controls.MetroButton browseMDDBtn;
        private MetroFramework.Controls.MetroLabel loadedMDDLabel;
        public MetroFramework.Controls.MetroButton mddRestartBtn;
        public MetroFramework.Controls.MetroCheckBox customPropertyCheckBox;
        public MetroFramework.Controls.MetroCheckBox secondLocalLanguageCheckBox;
        private System.Windows.Forms.Label secondLanguageLabel;
        public MetroFramework.Controls.MetroComboBox secondLanguageBox;
        private System.Windows.Forms.Label customPropertyLabel1;
        public MetroFramework.Controls.MetroComboBox customPropertyBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel iFieldExportLabel;
        public MetroFramework.Controls.MetroComboBox secondLocalLanguageComboBox;
        public MetroFramework.Controls.MetroComboBox localLanguagesComboBox;
        public MetroFramework.Controls.MetroCheckBox iFieldSecondLocalLanguageCheckBox;
        private System.Windows.Forms.GroupBox languagesGroupBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

