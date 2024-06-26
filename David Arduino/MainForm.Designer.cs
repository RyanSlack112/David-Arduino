﻿namespace David_Arduino
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.btnStop = new MaterialSkin.Controls.MaterialButton();
            this.pnlOutputControls = new System.Windows.Forms.Panel();
            this.lblUnit = new MaterialSkin.Controls.MaterialLabel();
            this.cmbUnit = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.lblOutput = new MaterialSkin.Controls.MaterialLabel();
            this.tabHitCounter = new System.Windows.Forms.TabPage();
            this.pnlTimerCtrls = new System.Windows.Forms.Panel();
            this.cbHitTimer = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblHitTimer = new MaterialSkin.Controls.MaterialLabel();
            this.btnHitTimer = new MaterialSkin.Controls.MaterialButton();
            this.txtHitTimer = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlHitCounterButtons = new System.Windows.Forms.Panel();
            this.btnHitCounterClose = new MaterialSkin.Controls.MaterialButton();
            this.btnHitCounterStart = new MaterialSkin.Controls.MaterialButton();
            this.btnHitCounterStop = new MaterialSkin.Controls.MaterialButton();
            this.tabControl = new System.Windows.Forms.TabPage();
            this.pnlControlButtons = new System.Windows.Forms.Panel();
            this.btnControlClose = new MaterialSkin.Controls.MaterialButton();
            this.btnControlStart = new MaterialSkin.Controls.MaterialButton();
            this.btnControlStop = new MaterialSkin.Controls.MaterialButton();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.tabsGraphView = new MaterialSkin.Controls.MaterialTabControl();
            this.tabGraphMain = new System.Windows.Forms.TabPage();
            this.pnlGraphMain = new System.Windows.Forms.Panel();
            this.crtGraphMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlGraphMainControls = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGraphMainUnits = new System.Windows.Forms.Panel();
            this.cmbGraphMainUnits = new MaterialSkin.Controls.MaterialComboBox();
            this.lblGraphMainChooseUnit = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGraphMainDate = new System.Windows.Forms.Panel();
            this.lblGraphMainSetDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpGraphMainDate = new System.Windows.Forms.DateTimePicker();
            this.pnlGraphMainButtons = new System.Windows.Forms.Panel();
            this.btnGraphMainClearGraph = new MaterialSkin.Controls.MaterialButton();
            this.btnGraphMainGenerateGraph = new MaterialSkin.Controls.MaterialButton();
            this.tabGraphHitCounter = new System.Windows.Forms.TabPage();
            this.pnlGraphHitCounter = new System.Windows.Forms.Panel();
            this.crtGraphHitCounter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlGraphHitCounterControls = new System.Windows.Forms.Panel();
            this.flGraphMainControls = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGraphHitCounterUnits = new System.Windows.Forms.Panel();
            this.cbGraphHitCounterUnits = new MaterialSkin.Controls.MaterialComboBox();
            this.lblGraphHitCounterChooseUnit = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGraphHitCounterDate = new System.Windows.Forms.Panel();
            this.lblGraphHitCounterDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpGraphHitCounterDate = new System.Windows.Forms.DateTimePicker();
            this.pnlGraphHitCounterSession = new System.Windows.Forms.Panel();
            this.cmbGraphHitCounterSessions = new MaterialSkin.Controls.MaterialComboBox();
            this.lblGraphHitCounterSession = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGraphHitCounterButtons = new System.Windows.Forms.Panel();
            this.btnGraphHitCounterClearGraph = new MaterialSkin.Controls.MaterialButton();
            this.btnGraphHitCounterGenerateGraph = new MaterialSkin.Controls.MaterialButton();
            this.tabGraphControl = new System.Windows.Forms.TabPage();
            this.pnlGraphControl = new System.Windows.Forms.Panel();
            this.crtGraphControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlGraphControlControls = new System.Windows.Forms.Panel();
            this.flGraphControlControls = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGraphControlUnits = new System.Windows.Forms.Panel();
            this.cmbGraphControlUnits = new MaterialSkin.Controls.MaterialComboBox();
            this.lblGraphControlUnits = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGraphControlDate = new System.Windows.Forms.Panel();
            this.lblGraphCOntrolDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpGraphControlDate = new System.Windows.Forms.DateTimePicker();
            this.pnlGraphControlSession = new System.Windows.Forms.Panel();
            this.cmbGraphControlSessions = new MaterialSkin.Controls.MaterialComboBox();
            this.lblGraphControlSessions = new MaterialSkin.Controls.MaterialLabel();
            this.pnlGraphControlButtons = new System.Windows.Forms.Panel();
            this.btnGraphControlClear = new MaterialSkin.Controls.MaterialButton();
            this.btnGraphControlGenerate = new MaterialSkin.Controls.MaterialButton();
            this.tsGraphView = new MaterialSkin.Controls.MaterialTabSelector();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.btnGraphClose = new MaterialSkin.Controls.MaterialButton();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.tsStats = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabsStatistics = new MaterialSkin.Controls.MaterialTabControl();
            this.tabStatsMain = new System.Windows.Forms.TabPage();
            this.pnlStatsMainListView = new System.Windows.Forms.Panel();
            this.dgvStatsMain = new System.Windows.Forms.DataGridView();
            this.pnlStatsMainButtons = new System.Windows.Forms.Panel();
            this.btnStatsMainClear = new MaterialSkin.Controls.MaterialButton();
            this.btnStatsMainGenerate = new MaterialSkin.Controls.MaterialButton();
            this.dtpStatsMainDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatsMainDate = new MaterialSkin.Controls.MaterialLabel();
            this.pnlStatsButtons = new System.Windows.Forms.Panel();
            this.btnStatsClose = new MaterialSkin.Controls.MaterialButton();
            this.tabStatsHitCounter = new System.Windows.Forms.TabPage();
            this.pnlStatsHitCounter = new System.Windows.Forms.Panel();
            this.dgvStatsHitCounter = new System.Windows.Forms.DataGridView();
            this.pnlStatsHitCounterControls = new System.Windows.Forms.Panel();
            this.btnStatsHitCounterClear = new MaterialSkin.Controls.MaterialButton();
            this.btnStatsHitCounterGenerate = new MaterialSkin.Controls.MaterialButton();
            this.dtpStatsHitCounterDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatsHitCounterDate = new MaterialSkin.Controls.MaterialLabel();
            this.pnlStatsHitCounterClose = new System.Windows.Forms.Panel();
            this.btnStatsHitCounterClose = new MaterialSkin.Controls.MaterialButton();
            this.tabStatsControl = new System.Windows.Forms.TabPage();
            this.pnlStatsControl = new System.Windows.Forms.Panel();
            this.dgvStatsControl = new System.Windows.Forms.DataGridView();
            this.pnlStatsControlControls = new System.Windows.Forms.Panel();
            this.btnStatsControlClear = new MaterialSkin.Controls.MaterialButton();
            this.btnStatsControlGenerate = new MaterialSkin.Controls.MaterialButton();
            this.dtpStatsControlDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlStatsControlClose = new System.Windows.Forms.Panel();
            this.btnStatsControlClose = new MaterialSkin.Controls.MaterialButton();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.pnlChoosePort = new System.Windows.Forms.Panel();
            this.txtCurrentPort = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCurrentPort = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenPort = new MaterialSkin.Controls.MaterialButton();
            this.cmbPorts = new MaterialSkin.Controls.MaterialComboBox();
            this.lblChoosePort = new MaterialSkin.Controls.MaterialLabel();
            this.pnlDBCheck = new System.Windows.Forms.Panel();
            this.btnDBCheck = new MaterialSkin.Controls.MaterialButton();
            this.lblDBCheck = new MaterialSkin.Controls.MaterialLabel();
            this.pnlSettingsClose = new System.Windows.Forms.Panel();
            this.btnSettingsClose = new MaterialSkin.Controls.MaterialButton();
            this.pnlMassInput = new System.Windows.Forms.Panel();
            this.txtCurrentMass = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCurrentMass = new MaterialSkin.Controls.MaterialLabel();
            this.btnChangeMass = new MaterialSkin.Controls.MaterialButton();
            this.lblMass = new MaterialSkin.Controls.MaterialLabel();
            this.txtMassInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.btnCheck = new MaterialSkin.Controls.MaterialButton();
            this.lblCheck = new MaterialSkin.Controls.MaterialLabel();
            this.pnlTheme = new System.Windows.Forms.Panel();
            this.lblTheme = new MaterialSkin.Controls.MaterialLabel();
            this.btnDark = new MaterialSkin.Controls.MaterialButton();
            this.btnLight = new MaterialSkin.Controls.MaterialButton();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefreshPorts = new MaterialSkin.Controls.MaterialButton();
            this.tabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlOutputControls.SuspendLayout();
            this.pnlOutput.SuspendLayout();
            this.tabHitCounter.SuspendLayout();
            this.pnlTimerCtrls.SuspendLayout();
            this.pnlHitCounterButtons.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pnlControlButtons.SuspendLayout();
            this.tabGraph.SuspendLayout();
            this.tabsGraphView.SuspendLayout();
            this.tabGraphMain.SuspendLayout();
            this.pnlGraphMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtGraphMain)).BeginInit();
            this.pnlGraphMainControls.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlGraphMainUnits.SuspendLayout();
            this.pnlGraphMainDate.SuspendLayout();
            this.pnlGraphMainButtons.SuspendLayout();
            this.tabGraphHitCounter.SuspendLayout();
            this.pnlGraphHitCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtGraphHitCounter)).BeginInit();
            this.pnlGraphHitCounterControls.SuspendLayout();
            this.flGraphMainControls.SuspendLayout();
            this.pnlGraphHitCounterUnits.SuspendLayout();
            this.pnlGraphHitCounterDate.SuspendLayout();
            this.pnlGraphHitCounterSession.SuspendLayout();
            this.pnlGraphHitCounterButtons.SuspendLayout();
            this.tabGraphControl.SuspendLayout();
            this.pnlGraphControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtGraphControl)).BeginInit();
            this.pnlGraphControlControls.SuspendLayout();
            this.flGraphControlControls.SuspendLayout();
            this.pnlGraphControlUnits.SuspendLayout();
            this.pnlGraphControlDate.SuspendLayout();
            this.pnlGraphControlSession.SuspendLayout();
            this.pnlGraphControlButtons.SuspendLayout();
            this.pnlClose.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.tabsStatistics.SuspendLayout();
            this.tabStatsMain.SuspendLayout();
            this.pnlStatsMainListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsMain)).BeginInit();
            this.pnlStatsMainButtons.SuspendLayout();
            this.pnlStatsButtons.SuspendLayout();
            this.tabStatsHitCounter.SuspendLayout();
            this.pnlStatsHitCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsHitCounter)).BeginInit();
            this.pnlStatsHitCounterControls.SuspendLayout();
            this.pnlStatsHitCounterClose.SuspendLayout();
            this.tabStatsControl.SuspendLayout();
            this.pnlStatsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsControl)).BeginInit();
            this.pnlStatsControlControls.SuspendLayout();
            this.pnlStatsControlClose.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.pnlChoosePort.SuspendLayout();
            this.pnlDBCheck.SuspendLayout();
            this.pnlSettingsClose.SuspendLayout();
            this.pnlMassInput.SuspendLayout();
            this.pnlCheck.SuspendLayout();
            this.pnlTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMain);
            this.tabs.Controls.Add(this.tabHitCounter);
            this.tabs.Controls.Add(this.tabControl);
            this.tabs.Controls.Add(this.tabGraph);
            this.tabs.Controls.Add(this.tabStatistics);
            this.tabs.Controls.Add(this.tabSettings);
            this.tabs.Depth = 0;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.ImageList = this.imgList;
            this.tabs.Location = new System.Drawing.Point(3, 64);
            this.tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1067, 533);
            this.tabs.TabIndex = 3;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pnlButtons);
            this.tabMain.Controls.Add(this.pnlOutputControls);
            this.tabMain.Controls.Add(this.pnlOutput);
            this.tabMain.ImageKey = "home.png";
            this.tabMain.Location = new System.Drawing.Point(4, 39);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1059, 490);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnStart);
            this.pnlButtons.Controls.Add(this.btnStop);
            this.pnlButtons.Location = new System.Drawing.Point(901, 441);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(155, 46);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(85, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(66, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.AutoSize = false;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStart.Depth = 0;
            this.btnStart.HighEmphasis = true;
            this.btnStart.Icon = null;
            this.btnStart.Location = new System.Drawing.Point(10, 7);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStart.Size = new System.Drawing.Size(67, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStart.UseAccentColor = false;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.AutoSize = false;
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStop.Depth = 0;
            this.btnStop.HighEmphasis = true;
            this.btnStop.Icon = null;
            this.btnStop.Location = new System.Drawing.Point(10, 7);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStop.Size = new System.Drawing.Size(67, 36);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStop.UseAccentColor = false;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlOutputControls
            // 
            this.pnlOutputControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOutputControls.Controls.Add(this.lblUnit);
            this.pnlOutputControls.Controls.Add(this.cmbUnit);
            this.pnlOutputControls.Location = new System.Drawing.Point(853, 6);
            this.pnlOutputControls.Name = "pnlOutputControls";
            this.pnlOutputControls.Size = new System.Drawing.Size(185, 112);
            this.pnlOutputControls.TabIndex = 4;
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit.Depth = 0;
            this.lblUnit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUnit.Location = new System.Drawing.Point(18, 15);
            this.lblUnit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(151, 19);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "Select Unit:";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnit.AutoResize = false;
            this.cmbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbUnit.Depth = 0;
            this.cmbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUnit.DropDownHeight = 174;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.DropDownWidth = 121;
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.IntegralHeight = false;
            this.cmbUnit.ItemHeight = 43;
            this.cmbUnit.Items.AddRange(new object[] {
            "Force",
            "Acceleration"});
            this.cmbUnit.Location = new System.Drawing.Point(18, 37);
            this.cmbUnit.MaxDropDownItems = 4;
            this.cmbUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(151, 49);
            this.cmbUnit.StartIndex = 0;
            this.cmbUnit.TabIndex = 0;
            // 
            // pnlOutput
            // 
            this.pnlOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOutput.Controls.Add(this.lblOutput);
            this.pnlOutput.Location = new System.Drawing.Point(179, 6);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(655, 409);
            this.pnlOutput.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Depth = 0;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutput.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOutput.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.lblOutput.Location = new System.Drawing.Point(0, 0);
            this.lblOutput.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(655, 409);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabHitCounter
            // 
            this.tabHitCounter.Controls.Add(this.pnlTimerCtrls);
            this.tabHitCounter.Controls.Add(this.pnlHitCounterButtons);
            this.tabHitCounter.ImageKey = "Hit Counter.png";
            this.tabHitCounter.Location = new System.Drawing.Point(4, 39);
            this.tabHitCounter.Name = "tabHitCounter";
            this.tabHitCounter.Size = new System.Drawing.Size(1059, 490);
            this.tabHitCounter.TabIndex = 4;
            this.tabHitCounter.Text = "Hit Counter";
            this.tabHitCounter.UseVisualStyleBackColor = true;
            // 
            // pnlTimerCtrls
            // 
            this.pnlTimerCtrls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimerCtrls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimerCtrls.Controls.Add(this.cbHitTimer);
            this.pnlTimerCtrls.Controls.Add(this.lblHitTimer);
            this.pnlTimerCtrls.Controls.Add(this.btnHitTimer);
            this.pnlTimerCtrls.Controls.Add(this.txtHitTimer);
            this.pnlTimerCtrls.Location = new System.Drawing.Point(856, 3);
            this.pnlTimerCtrls.Name = "pnlTimerCtrls";
            this.pnlTimerCtrls.Size = new System.Drawing.Size(200, 188);
            this.pnlTimerCtrls.TabIndex = 1;
            // 
            // cbHitTimer
            // 
            this.cbHitTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHitTimer.Depth = 0;
            this.cbHitTimer.Location = new System.Drawing.Point(20, 11);
            this.cbHitTimer.Margin = new System.Windows.Forms.Padding(0);
            this.cbHitTimer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbHitTimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbHitTimer.Name = "cbHitTimer";
            this.cbHitTimer.ReadOnly = false;
            this.cbHitTimer.Ripple = true;
            this.cbHitTimer.Size = new System.Drawing.Size(158, 37);
            this.cbHitTimer.TabIndex = 3;
            this.cbHitTimer.Text = "Enable Timer";
            this.cbHitTimer.UseVisualStyleBackColor = true;
            this.cbHitTimer.CheckedChanged += new System.EventHandler(this.cbHitTimer_CheckedChanged);
            // 
            // lblHitTimer
            // 
            this.lblHitTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHitTimer.Depth = 0;
            this.lblHitTimer.Enabled = false;
            this.lblHitTimer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHitTimer.Location = new System.Drawing.Point(17, 58);
            this.lblHitTimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHitTimer.Name = "lblHitTimer";
            this.lblHitTimer.Size = new System.Drawing.Size(161, 19);
            this.lblHitTimer.TabIndex = 2;
            this.lblHitTimer.Text = "Set Timer";
            this.lblHitTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHitTimer
            // 
            this.btnHitTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHitTimer.AutoSize = false;
            this.btnHitTimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHitTimer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHitTimer.Depth = 0;
            this.btnHitTimer.Enabled = false;
            this.btnHitTimer.HighEmphasis = true;
            this.btnHitTimer.Icon = null;
            this.btnHitTimer.Location = new System.Drawing.Point(20, 133);
            this.btnHitTimer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHitTimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHitTimer.Name = "btnHitTimer";
            this.btnHitTimer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHitTimer.Size = new System.Drawing.Size(158, 36);
            this.btnHitTimer.TabIndex = 1;
            this.btnHitTimer.Text = "Set Timer";
            this.btnHitTimer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHitTimer.UseAccentColor = false;
            this.btnHitTimer.UseVisualStyleBackColor = true;
            this.btnHitTimer.Click += new System.EventHandler(this.btnHitTimer_Click);
            // 
            // txtHitTimer
            // 
            this.txtHitTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHitTimer.AnimateReadOnly = false;
            this.txtHitTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtHitTimer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHitTimer.Depth = 0;
            this.txtHitTimer.Enabled = false;
            this.txtHitTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHitTimer.HideSelection = true;
            this.txtHitTimer.Hint = "Time In Seconds";
            this.txtHitTimer.LeadingIcon = null;
            this.txtHitTimer.Location = new System.Drawing.Point(20, 80);
            this.txtHitTimer.MaxLength = 32767;
            this.txtHitTimer.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHitTimer.Name = "txtHitTimer";
            this.txtHitTimer.PasswordChar = '\0';
            this.txtHitTimer.PrefixSuffixText = null;
            this.txtHitTimer.ReadOnly = false;
            this.txtHitTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHitTimer.SelectedText = "";
            this.txtHitTimer.SelectionLength = 0;
            this.txtHitTimer.SelectionStart = 0;
            this.txtHitTimer.ShortcutsEnabled = true;
            this.txtHitTimer.Size = new System.Drawing.Size(158, 48);
            this.txtHitTimer.TabIndex = 0;
            this.txtHitTimer.TabStop = false;
            this.txtHitTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHitTimer.TrailingIcon = null;
            this.txtHitTimer.UseSystemPasswordChar = false;
            // 
            // pnlHitCounterButtons
            // 
            this.pnlHitCounterButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHitCounterButtons.Controls.Add(this.btnHitCounterClose);
            this.pnlHitCounterButtons.Controls.Add(this.btnHitCounterStart);
            this.pnlHitCounterButtons.Controls.Add(this.btnHitCounterStop);
            this.pnlHitCounterButtons.Location = new System.Drawing.Point(884, 443);
            this.pnlHitCounterButtons.Name = "pnlHitCounterButtons";
            this.pnlHitCounterButtons.Size = new System.Drawing.Size(172, 44);
            this.pnlHitCounterButtons.TabIndex = 0;
            // 
            // btnHitCounterClose
            // 
            this.btnHitCounterClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHitCounterClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHitCounterClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHitCounterClose.Depth = 0;
            this.btnHitCounterClose.HighEmphasis = true;
            this.btnHitCounterClose.Icon = null;
            this.btnHitCounterClose.Location = new System.Drawing.Point(102, 5);
            this.btnHitCounterClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHitCounterClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHitCounterClose.Name = "btnHitCounterClose";
            this.btnHitCounterClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHitCounterClose.Size = new System.Drawing.Size(66, 36);
            this.btnHitCounterClose.TabIndex = 0;
            this.btnHitCounterClose.Text = "Close";
            this.btnHitCounterClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHitCounterClose.UseAccentColor = false;
            this.btnHitCounterClose.UseVisualStyleBackColor = true;
            this.btnHitCounterClose.Click += new System.EventHandler(this.btnHitCounterClose_Click);
            // 
            // btnHitCounterStart
            // 
            this.btnHitCounterStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHitCounterStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHitCounterStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHitCounterStart.Depth = 0;
            this.btnHitCounterStart.HighEmphasis = true;
            this.btnHitCounterStart.Icon = null;
            this.btnHitCounterStart.Location = new System.Drawing.Point(27, 5);
            this.btnHitCounterStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHitCounterStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHitCounterStart.Name = "btnHitCounterStart";
            this.btnHitCounterStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHitCounterStart.Size = new System.Drawing.Size(67, 36);
            this.btnHitCounterStart.TabIndex = 1;
            this.btnHitCounterStart.Text = "Start";
            this.btnHitCounterStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHitCounterStart.UseAccentColor = false;
            this.btnHitCounterStart.UseVisualStyleBackColor = true;
            this.btnHitCounterStart.Click += new System.EventHandler(this.btnHitCounterStart_Click);
            // 
            // btnHitCounterStop
            // 
            this.btnHitCounterStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHitCounterStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHitCounterStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHitCounterStop.Depth = 0;
            this.btnHitCounterStop.HighEmphasis = true;
            this.btnHitCounterStop.Icon = null;
            this.btnHitCounterStop.Location = new System.Drawing.Point(30, 5);
            this.btnHitCounterStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHitCounterStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHitCounterStop.Name = "btnHitCounterStop";
            this.btnHitCounterStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHitCounterStop.Size = new System.Drawing.Size(64, 36);
            this.btnHitCounterStop.TabIndex = 1;
            this.btnHitCounterStop.Text = "Stop";
            this.btnHitCounterStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHitCounterStop.UseAccentColor = false;
            this.btnHitCounterStop.UseVisualStyleBackColor = true;
            this.btnHitCounterStop.Visible = false;
            this.btnHitCounterStop.Click += new System.EventHandler(this.btnHitCounterStop_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pnlControlButtons);
            this.tabControl.ImageKey = "Control.png";
            this.tabControl.Location = new System.Drawing.Point(4, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1059, 490);
            this.tabControl.TabIndex = 5;
            this.tabControl.Text = "Control";
            this.tabControl.UseVisualStyleBackColor = true;
            // 
            // pnlControlButtons
            // 
            this.pnlControlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlButtons.Controls.Add(this.btnControlClose);
            this.pnlControlButtons.Controls.Add(this.btnControlStart);
            this.pnlControlButtons.Controls.Add(this.btnControlStop);
            this.pnlControlButtons.Location = new System.Drawing.Point(882, 439);
            this.pnlControlButtons.Name = "pnlControlButtons";
            this.pnlControlButtons.Size = new System.Drawing.Size(174, 48);
            this.pnlControlButtons.TabIndex = 0;
            // 
            // btnControlClose
            // 
            this.btnControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnControlClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnControlClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnControlClose.Depth = 0;
            this.btnControlClose.HighEmphasis = true;
            this.btnControlClose.Icon = null;
            this.btnControlClose.Location = new System.Drawing.Point(104, 9);
            this.btnControlClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnControlClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnControlClose.Name = "btnControlClose";
            this.btnControlClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnControlClose.Size = new System.Drawing.Size(66, 36);
            this.btnControlClose.TabIndex = 1;
            this.btnControlClose.Text = "Close";
            this.btnControlClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnControlClose.UseAccentColor = false;
            this.btnControlClose.UseVisualStyleBackColor = true;
            this.btnControlClose.Click += new System.EventHandler(this.btnControlClose_Click);
            // 
            // btnControlStart
            // 
            this.btnControlStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnControlStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnControlStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnControlStart.Depth = 0;
            this.btnControlStart.HighEmphasis = true;
            this.btnControlStart.Icon = null;
            this.btnControlStart.Location = new System.Drawing.Point(29, 9);
            this.btnControlStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnControlStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnControlStart.Name = "btnControlStart";
            this.btnControlStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnControlStart.Size = new System.Drawing.Size(67, 36);
            this.btnControlStart.TabIndex = 1;
            this.btnControlStart.Text = "Start";
            this.btnControlStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnControlStart.UseAccentColor = false;
            this.btnControlStart.UseVisualStyleBackColor = true;
            this.btnControlStart.Click += new System.EventHandler(this.btnControlStart_Click);
            // 
            // btnControlStop
            // 
            this.btnControlStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnControlStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnControlStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnControlStop.Depth = 0;
            this.btnControlStop.HighEmphasis = true;
            this.btnControlStop.Icon = null;
            this.btnControlStop.Location = new System.Drawing.Point(32, 9);
            this.btnControlStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnControlStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnControlStop.Name = "btnControlStop";
            this.btnControlStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnControlStop.Size = new System.Drawing.Size(64, 36);
            this.btnControlStop.TabIndex = 1;
            this.btnControlStop.Text = "Stop";
            this.btnControlStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnControlStop.UseAccentColor = false;
            this.btnControlStop.UseVisualStyleBackColor = true;
            this.btnControlStop.Visible = false;
            this.btnControlStop.Click += new System.EventHandler(this.btnControlStop_Click);
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.tabsGraphView);
            this.tabGraph.Controls.Add(this.tsGraphView);
            this.tabGraph.Controls.Add(this.pnlClose);
            this.tabGraph.ImageKey = "Graph.png";
            this.tabGraph.Location = new System.Drawing.Point(4, 39);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(1059, 490);
            this.tabGraph.TabIndex = 1;
            this.tabGraph.Text = "Graph View";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // tabsGraphView
            // 
            this.tabsGraphView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsGraphView.Controls.Add(this.tabGraphMain);
            this.tabsGraphView.Controls.Add(this.tabGraphHitCounter);
            this.tabsGraphView.Controls.Add(this.tabGraphControl);
            this.tabsGraphView.Depth = 0;
            this.tabsGraphView.Location = new System.Drawing.Point(3, 43);
            this.tabsGraphView.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabsGraphView.Multiline = true;
            this.tabsGraphView.Name = "tabsGraphView";
            this.tabsGraphView.SelectedIndex = 0;
            this.tabsGraphView.Size = new System.Drawing.Size(1053, 395);
            this.tabsGraphView.TabIndex = 4;
            // 
            // tabGraphMain
            // 
            this.tabGraphMain.Controls.Add(this.pnlGraphMain);
            this.tabGraphMain.Controls.Add(this.pnlGraphMainControls);
            this.tabGraphMain.Location = new System.Drawing.Point(4, 22);
            this.tabGraphMain.Name = "tabGraphMain";
            this.tabGraphMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraphMain.Size = new System.Drawing.Size(1045, 369);
            this.tabGraphMain.TabIndex = 0;
            this.tabGraphMain.Text = "Main";
            this.tabGraphMain.UseVisualStyleBackColor = true;
            // 
            // pnlGraphMain
            // 
            this.pnlGraphMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphMain.Controls.Add(this.crtGraphMain);
            this.pnlGraphMain.Location = new System.Drawing.Point(6, 3);
            this.pnlGraphMain.Name = "pnlGraphMain";
            this.pnlGraphMain.Size = new System.Drawing.Size(827, 360);
            this.pnlGraphMain.TabIndex = 1;
            // 
            // crtGraphMain
            // 
            chartArea1.Name = "ChartArea1";
            this.crtGraphMain.ChartAreas.Add(chartArea1);
            this.crtGraphMain.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.crtGraphMain.Legends.Add(legend1);
            this.crtGraphMain.Location = new System.Drawing.Point(0, 0);
            this.crtGraphMain.Name = "crtGraphMain";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DimGray;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "HitData";
            this.crtGraphMain.Series.Add(series1);
            this.crtGraphMain.Size = new System.Drawing.Size(827, 360);
            this.crtGraphMain.TabIndex = 0;
            this.crtGraphMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.crtGraphMain_MouseMove);
            // 
            // pnlGraphMainControls
            // 
            this.pnlGraphMainControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphMainControls.Controls.Add(this.flowLayoutPanel1);
            this.pnlGraphMainControls.Location = new System.Drawing.Point(839, 6);
            this.pnlGraphMainControls.Name = "pnlGraphMainControls";
            this.pnlGraphMainControls.Size = new System.Drawing.Size(200, 357);
            this.pnlGraphMainControls.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlGraphMainUnits);
            this.flowLayoutPanel1.Controls.Add(this.pnlGraphMainDate);
            this.flowLayoutPanel1.Controls.Add(this.pnlGraphMainButtons);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 357);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pnlGraphMainUnits
            // 
            this.pnlGraphMainUnits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGraphMainUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphMainUnits.Controls.Add(this.cmbGraphMainUnits);
            this.pnlGraphMainUnits.Controls.Add(this.lblGraphMainChooseUnit);
            this.pnlGraphMainUnits.Location = new System.Drawing.Point(3, 3);
            this.pnlGraphMainUnits.Name = "pnlGraphMainUnits";
            this.pnlGraphMainUnits.Size = new System.Drawing.Size(194, 112);
            this.pnlGraphMainUnits.TabIndex = 0;
            // 
            // cmbGraphMainUnits
            // 
            this.cmbGraphMainUnits.AutoResize = false;
            this.cmbGraphMainUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGraphMainUnits.Depth = 0;
            this.cmbGraphMainUnits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGraphMainUnits.DropDownHeight = 174;
            this.cmbGraphMainUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphMainUnits.DropDownWidth = 121;
            this.cmbGraphMainUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGraphMainUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGraphMainUnits.FormattingEnabled = true;
            this.cmbGraphMainUnits.IntegralHeight = false;
            this.cmbGraphMainUnits.ItemHeight = 43;
            this.cmbGraphMainUnits.Items.AddRange(new object[] {
            "Force",
            "Acceleration"});
            this.cmbGraphMainUnits.Location = new System.Drawing.Point(15, 39);
            this.cmbGraphMainUnits.MaxDropDownItems = 4;
            this.cmbGraphMainUnits.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGraphMainUnits.Name = "cmbGraphMainUnits";
            this.cmbGraphMainUnits.Size = new System.Drawing.Size(162, 49);
            this.cmbGraphMainUnits.StartIndex = 0;
            this.cmbGraphMainUnits.TabIndex = 2;
            // 
            // lblGraphMainChooseUnit
            // 
            this.lblGraphMainChooseUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraphMainChooseUnit.Depth = 0;
            this.lblGraphMainChooseUnit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGraphMainChooseUnit.Location = new System.Drawing.Point(15, 17);
            this.lblGraphMainChooseUnit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGraphMainChooseUnit.Name = "lblGraphMainChooseUnit";
            this.lblGraphMainChooseUnit.Size = new System.Drawing.Size(158, 19);
            this.lblGraphMainChooseUnit.TabIndex = 1;
            this.lblGraphMainChooseUnit.Text = "Choose Unit";
            this.lblGraphMainChooseUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraphMainDate
            // 
            this.pnlGraphMainDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGraphMainDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphMainDate.Controls.Add(this.lblGraphMainSetDate);
            this.pnlGraphMainDate.Controls.Add(this.dtpGraphMainDate);
            this.pnlGraphMainDate.Location = new System.Drawing.Point(3, 121);
            this.pnlGraphMainDate.Name = "pnlGraphMainDate";
            this.pnlGraphMainDate.Size = new System.Drawing.Size(194, 60);
            this.pnlGraphMainDate.TabIndex = 1;
            // 
            // lblGraphMainSetDate
            // 
            this.lblGraphMainSetDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraphMainSetDate.Depth = 0;
            this.lblGraphMainSetDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGraphMainSetDate.Location = new System.Drawing.Point(3, 4);
            this.lblGraphMainSetDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGraphMainSetDate.Name = "lblGraphMainSetDate";
            this.lblGraphMainSetDate.Size = new System.Drawing.Size(184, 19);
            this.lblGraphMainSetDate.TabIndex = 1;
            this.lblGraphMainSetDate.Text = "Set Date";
            this.lblGraphMainSetDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpGraphMainDate
            // 
            this.dtpGraphMainDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpGraphMainDate.CustomFormat = "ddd dd\'/\'MM\'/\'yyyy";
            this.dtpGraphMainDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGraphMainDate.Location = new System.Drawing.Point(2, 26);
            this.dtpGraphMainDate.Name = "dtpGraphMainDate";
            this.dtpGraphMainDate.Size = new System.Drawing.Size(190, 20);
            this.dtpGraphMainDate.TabIndex = 0;
            // 
            // pnlGraphMainButtons
            // 
            this.pnlGraphMainButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGraphMainButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphMainButtons.Controls.Add(this.btnGraphMainClearGraph);
            this.pnlGraphMainButtons.Controls.Add(this.btnGraphMainGenerateGraph);
            this.pnlGraphMainButtons.Location = new System.Drawing.Point(3, 187);
            this.pnlGraphMainButtons.Name = "pnlGraphMainButtons";
            this.pnlGraphMainButtons.Size = new System.Drawing.Size(193, 163);
            this.pnlGraphMainButtons.TabIndex = 2;
            // 
            // btnGraphMainClearGraph
            // 
            this.btnGraphMainClearGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraphMainClearGraph.AutoSize = false;
            this.btnGraphMainClearGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraphMainClearGraph.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGraphMainClearGraph.Depth = 0;
            this.btnGraphMainClearGraph.HighEmphasis = true;
            this.btnGraphMainClearGraph.Icon = null;
            this.btnGraphMainClearGraph.Location = new System.Drawing.Point(18, 72);
            this.btnGraphMainClearGraph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGraphMainClearGraph.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGraphMainClearGraph.Name = "btnGraphMainClearGraph";
            this.btnGraphMainClearGraph.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGraphMainClearGraph.Size = new System.Drawing.Size(154, 36);
            this.btnGraphMainClearGraph.TabIndex = 1;
            this.btnGraphMainClearGraph.Text = "Clear Graph";
            this.btnGraphMainClearGraph.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGraphMainClearGraph.UseAccentColor = false;
            this.btnGraphMainClearGraph.UseVisualStyleBackColor = true;
            this.btnGraphMainClearGraph.Click += new System.EventHandler(this.btnGraphMainClearGraph_Click);
            // 
            // btnGraphMainGenerateGraph
            // 
            this.btnGraphMainGenerateGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraphMainGenerateGraph.AutoSize = false;
            this.btnGraphMainGenerateGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraphMainGenerateGraph.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGraphMainGenerateGraph.Depth = 0;
            this.btnGraphMainGenerateGraph.HighEmphasis = true;
            this.btnGraphMainGenerateGraph.Icon = null;
            this.btnGraphMainGenerateGraph.Location = new System.Drawing.Point(18, 28);
            this.btnGraphMainGenerateGraph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGraphMainGenerateGraph.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGraphMainGenerateGraph.Name = "btnGraphMainGenerateGraph";
            this.btnGraphMainGenerateGraph.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGraphMainGenerateGraph.Size = new System.Drawing.Size(154, 36);
            this.btnGraphMainGenerateGraph.TabIndex = 0;
            this.btnGraphMainGenerateGraph.Text = "Generate Graph";
            this.btnGraphMainGenerateGraph.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGraphMainGenerateGraph.UseAccentColor = false;
            this.btnGraphMainGenerateGraph.UseVisualStyleBackColor = true;
            this.btnGraphMainGenerateGraph.Click += new System.EventHandler(this.btnGraphMainGenerateGraph_Click);
            // 
            // tabGraphHitCounter
            // 
            this.tabGraphHitCounter.Controls.Add(this.pnlGraphHitCounter);
            this.tabGraphHitCounter.Controls.Add(this.pnlGraphHitCounterControls);
            this.tabGraphHitCounter.Location = new System.Drawing.Point(4, 22);
            this.tabGraphHitCounter.Name = "tabGraphHitCounter";
            this.tabGraphHitCounter.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraphHitCounter.Size = new System.Drawing.Size(1045, 369);
            this.tabGraphHitCounter.TabIndex = 1;
            this.tabGraphHitCounter.Text = "Hit Counter";
            this.tabGraphHitCounter.UseVisualStyleBackColor = true;
            // 
            // pnlGraphHitCounter
            // 
            this.pnlGraphHitCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphHitCounter.Controls.Add(this.crtGraphHitCounter);
            this.pnlGraphHitCounter.Location = new System.Drawing.Point(3, 3);
            this.pnlGraphHitCounter.Name = "pnlGraphHitCounter";
            this.pnlGraphHitCounter.Size = new System.Drawing.Size(827, 363);
            this.pnlGraphHitCounter.TabIndex = 2;
            // 
            // crtGraphHitCounter
            // 
            chartArea2.Name = "ChartArea1";
            this.crtGraphHitCounter.ChartAreas.Add(chartArea2);
            this.crtGraphHitCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.crtGraphHitCounter.Legends.Add(legend2);
            this.crtGraphHitCounter.Location = new System.Drawing.Point(0, 0);
            this.crtGraphHitCounter.Name = "crtGraphHitCounter";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.DimGray;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Black;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "HitData";
            this.crtGraphHitCounter.Series.Add(series2);
            this.crtGraphHitCounter.Size = new System.Drawing.Size(827, 363);
            this.crtGraphHitCounter.TabIndex = 0;
            // 
            // pnlGraphHitCounterControls
            // 
            this.pnlGraphHitCounterControls.Controls.Add(this.flGraphMainControls);
            this.pnlGraphHitCounterControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGraphHitCounterControls.Location = new System.Drawing.Point(842, 3);
            this.pnlGraphHitCounterControls.Name = "pnlGraphHitCounterControls";
            this.pnlGraphHitCounterControls.Size = new System.Drawing.Size(200, 363);
            this.pnlGraphHitCounterControls.TabIndex = 1;
            // 
            // flGraphMainControls
            // 
            this.flGraphMainControls.Controls.Add(this.pnlGraphHitCounterUnits);
            this.flGraphMainControls.Controls.Add(this.pnlGraphHitCounterDate);
            this.flGraphMainControls.Controls.Add(this.pnlGraphHitCounterSession);
            this.flGraphMainControls.Controls.Add(this.pnlGraphHitCounterButtons);
            this.flGraphMainControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flGraphMainControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flGraphMainControls.Location = new System.Drawing.Point(0, 0);
            this.flGraphMainControls.Name = "flGraphMainControls";
            this.flGraphMainControls.Size = new System.Drawing.Size(200, 363);
            this.flGraphMainControls.TabIndex = 0;
            // 
            // pnlGraphHitCounterUnits
            // 
            this.pnlGraphHitCounterUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphHitCounterUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphHitCounterUnits.Controls.Add(this.cbGraphHitCounterUnits);
            this.pnlGraphHitCounterUnits.Controls.Add(this.lblGraphHitCounterChooseUnit);
            this.pnlGraphHitCounterUnits.Location = new System.Drawing.Point(3, 3);
            this.pnlGraphHitCounterUnits.Name = "pnlGraphHitCounterUnits";
            this.pnlGraphHitCounterUnits.Size = new System.Drawing.Size(193, 111);
            this.pnlGraphHitCounterUnits.TabIndex = 0;
            // 
            // cbGraphHitCounterUnits
            // 
            this.cbGraphHitCounterUnits.AutoResize = false;
            this.cbGraphHitCounterUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbGraphHitCounterUnits.Depth = 0;
            this.cbGraphHitCounterUnits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbGraphHitCounterUnits.DropDownHeight = 174;
            this.cbGraphHitCounterUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphHitCounterUnits.DropDownWidth = 121;
            this.cbGraphHitCounterUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbGraphHitCounterUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbGraphHitCounterUnits.FormattingEnabled = true;
            this.cbGraphHitCounterUnits.IntegralHeight = false;
            this.cbGraphHitCounterUnits.ItemHeight = 43;
            this.cbGraphHitCounterUnits.Items.AddRange(new object[] {
            "Force",
            "Acceleration"});
            this.cbGraphHitCounterUnits.Location = new System.Drawing.Point(15, 39);
            this.cbGraphHitCounterUnits.MaxDropDownItems = 4;
            this.cbGraphHitCounterUnits.MouseState = MaterialSkin.MouseState.OUT;
            this.cbGraphHitCounterUnits.Name = "cbGraphHitCounterUnits";
            this.cbGraphHitCounterUnits.Size = new System.Drawing.Size(162, 49);
            this.cbGraphHitCounterUnits.StartIndex = 0;
            this.cbGraphHitCounterUnits.TabIndex = 2;
            // 
            // lblGraphHitCounterChooseUnit
            // 
            this.lblGraphHitCounterChooseUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraphHitCounterChooseUnit.Depth = 0;
            this.lblGraphHitCounterChooseUnit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGraphHitCounterChooseUnit.Location = new System.Drawing.Point(15, 17);
            this.lblGraphHitCounterChooseUnit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGraphHitCounterChooseUnit.Name = "lblGraphHitCounterChooseUnit";
            this.lblGraphHitCounterChooseUnit.Size = new System.Drawing.Size(157, 19);
            this.lblGraphHitCounterChooseUnit.TabIndex = 1;
            this.lblGraphHitCounterChooseUnit.Text = "Choose Unit";
            this.lblGraphHitCounterChooseUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraphHitCounterDate
            // 
            this.pnlGraphHitCounterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphHitCounterDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphHitCounterDate.Controls.Add(this.lblGraphHitCounterDate);
            this.pnlGraphHitCounterDate.Controls.Add(this.dtpGraphHitCounterDate);
            this.pnlGraphHitCounterDate.Location = new System.Drawing.Point(3, 120);
            this.pnlGraphHitCounterDate.Name = "pnlGraphHitCounterDate";
            this.pnlGraphHitCounterDate.Size = new System.Drawing.Size(193, 53);
            this.pnlGraphHitCounterDate.TabIndex = 1;
            // 
            // lblGraphHitCounterDate
            // 
            this.lblGraphHitCounterDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraphHitCounterDate.Depth = 0;
            this.lblGraphHitCounterDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGraphHitCounterDate.Location = new System.Drawing.Point(3, 0);
            this.lblGraphHitCounterDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGraphHitCounterDate.Name = "lblGraphHitCounterDate";
            this.lblGraphHitCounterDate.Size = new System.Drawing.Size(183, 19);
            this.lblGraphHitCounterDate.TabIndex = 1;
            this.lblGraphHitCounterDate.Text = "Set Date";
            this.lblGraphHitCounterDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpGraphHitCounterDate
            // 
            this.dtpGraphHitCounterDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpGraphHitCounterDate.CustomFormat = "ddd dd\'/\'MM\'/\'yyyy";
            this.dtpGraphHitCounterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGraphHitCounterDate.Location = new System.Drawing.Point(0, 22);
            this.dtpGraphHitCounterDate.Name = "dtpGraphHitCounterDate";
            this.dtpGraphHitCounterDate.Size = new System.Drawing.Size(189, 20);
            this.dtpGraphHitCounterDate.TabIndex = 0;
            this.dtpGraphHitCounterDate.ValueChanged += new System.EventHandler(this.dtpGraphHitCounterDate_ValueChanged);
            // 
            // pnlGraphHitCounterSession
            // 
            this.pnlGraphHitCounterSession.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphHitCounterSession.Controls.Add(this.cmbGraphHitCounterSessions);
            this.pnlGraphHitCounterSession.Controls.Add(this.lblGraphHitCounterSession);
            this.pnlGraphHitCounterSession.Location = new System.Drawing.Point(3, 179);
            this.pnlGraphHitCounterSession.Name = "pnlGraphHitCounterSession";
            this.pnlGraphHitCounterSession.Size = new System.Drawing.Size(193, 84);
            this.pnlGraphHitCounterSession.TabIndex = 2;
            // 
            // cmbGraphHitCounterSessions
            // 
            this.cmbGraphHitCounterSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGraphHitCounterSessions.AutoResize = false;
            this.cmbGraphHitCounterSessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGraphHitCounterSessions.Depth = 0;
            this.cmbGraphHitCounterSessions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGraphHitCounterSessions.DropDownHeight = 174;
            this.cmbGraphHitCounterSessions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphHitCounterSessions.DropDownWidth = 121;
            this.cmbGraphHitCounterSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGraphHitCounterSessions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGraphHitCounterSessions.FormattingEnabled = true;
            this.cmbGraphHitCounterSessions.IntegralHeight = false;
            this.cmbGraphHitCounterSessions.ItemHeight = 43;
            this.cmbGraphHitCounterSessions.Location = new System.Drawing.Point(15, 33);
            this.cmbGraphHitCounterSessions.MaxDropDownItems = 4;
            this.cmbGraphHitCounterSessions.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGraphHitCounterSessions.Name = "cmbGraphHitCounterSessions";
            this.cmbGraphHitCounterSessions.Size = new System.Drawing.Size(159, 49);
            this.cmbGraphHitCounterSessions.StartIndex = 0;
            this.cmbGraphHitCounterSessions.TabIndex = 1;
            // 
            // lblGraphHitCounterSession
            // 
            this.lblGraphHitCounterSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraphHitCounterSession.Depth = 0;
            this.lblGraphHitCounterSession.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGraphHitCounterSession.Location = new System.Drawing.Point(14, 11);
            this.lblGraphHitCounterSession.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGraphHitCounterSession.Name = "lblGraphHitCounterSession";
            this.lblGraphHitCounterSession.Size = new System.Drawing.Size(162, 19);
            this.lblGraphHitCounterSession.TabIndex = 0;
            this.lblGraphHitCounterSession.Text = "Choose Session";
            this.lblGraphHitCounterSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraphHitCounterButtons
            // 
            this.pnlGraphHitCounterButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphHitCounterButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphHitCounterButtons.Controls.Add(this.btnGraphHitCounterClearGraph);
            this.pnlGraphHitCounterButtons.Controls.Add(this.btnGraphHitCounterGenerateGraph);
            this.pnlGraphHitCounterButtons.Location = new System.Drawing.Point(3, 269);
            this.pnlGraphHitCounterButtons.Name = "pnlGraphHitCounterButtons";
            this.pnlGraphHitCounterButtons.Size = new System.Drawing.Size(193, 90);
            this.pnlGraphHitCounterButtons.TabIndex = 2;
            // 
            // btnGraphHitCounterClearGraph
            // 
            this.btnGraphHitCounterClearGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraphHitCounterClearGraph.AutoSize = false;
            this.btnGraphHitCounterClearGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraphHitCounterClearGraph.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGraphHitCounterClearGraph.Depth = 0;
            this.btnGraphHitCounterClearGraph.HighEmphasis = true;
            this.btnGraphHitCounterClearGraph.Icon = null;
            this.btnGraphHitCounterClearGraph.Location = new System.Drawing.Point(18, 46);
            this.btnGraphHitCounterClearGraph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGraphHitCounterClearGraph.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGraphHitCounterClearGraph.Name = "btnGraphHitCounterClearGraph";
            this.btnGraphHitCounterClearGraph.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGraphHitCounterClearGraph.Size = new System.Drawing.Size(154, 36);
            this.btnGraphHitCounterClearGraph.TabIndex = 1;
            this.btnGraphHitCounterClearGraph.Text = "Clear Graph";
            this.btnGraphHitCounterClearGraph.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGraphHitCounterClearGraph.UseAccentColor = false;
            this.btnGraphHitCounterClearGraph.UseVisualStyleBackColor = true;
            // 
            // btnGraphHitCounterGenerateGraph
            // 
            this.btnGraphHitCounterGenerateGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraphHitCounterGenerateGraph.AutoSize = false;
            this.btnGraphHitCounterGenerateGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraphHitCounterGenerateGraph.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGraphHitCounterGenerateGraph.Depth = 0;
            this.btnGraphHitCounterGenerateGraph.HighEmphasis = true;
            this.btnGraphHitCounterGenerateGraph.Icon = null;
            this.btnGraphHitCounterGenerateGraph.Location = new System.Drawing.Point(18, 6);
            this.btnGraphHitCounterGenerateGraph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGraphHitCounterGenerateGraph.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGraphHitCounterGenerateGraph.Name = "btnGraphHitCounterGenerateGraph";
            this.btnGraphHitCounterGenerateGraph.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGraphHitCounterGenerateGraph.Size = new System.Drawing.Size(154, 36);
            this.btnGraphHitCounterGenerateGraph.TabIndex = 0;
            this.btnGraphHitCounterGenerateGraph.Text = "Generate Graph";
            this.btnGraphHitCounterGenerateGraph.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGraphHitCounterGenerateGraph.UseAccentColor = false;
            this.btnGraphHitCounterGenerateGraph.UseVisualStyleBackColor = true;
            // 
            // tabGraphControl
            // 
            this.tabGraphControl.Controls.Add(this.pnlGraphControl);
            this.tabGraphControl.Controls.Add(this.pnlGraphControlControls);
            this.tabGraphControl.Location = new System.Drawing.Point(4, 22);
            this.tabGraphControl.Name = "tabGraphControl";
            this.tabGraphControl.Size = new System.Drawing.Size(1045, 369);
            this.tabGraphControl.TabIndex = 2;
            this.tabGraphControl.Text = "Control";
            this.tabGraphControl.UseVisualStyleBackColor = true;
            // 
            // pnlGraphControl
            // 
            this.pnlGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphControl.Controls.Add(this.crtGraphControl);
            this.pnlGraphControl.Location = new System.Drawing.Point(4, 6);
            this.pnlGraphControl.Name = "pnlGraphControl";
            this.pnlGraphControl.Size = new System.Drawing.Size(832, 360);
            this.pnlGraphControl.TabIndex = 2;
            // 
            // crtGraphControl
            // 
            chartArea3.Name = "ChartArea1";
            this.crtGraphControl.ChartAreas.Add(chartArea3);
            this.crtGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.crtGraphControl.Legends.Add(legend3);
            this.crtGraphControl.Location = new System.Drawing.Point(0, 0);
            this.crtGraphControl.Name = "crtGraphControl";
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.DimGray;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Black;
            series3.MarkerSize = 8;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "ControlData";
            series3.ShadowColor = System.Drawing.Color.Transparent;
            this.crtGraphControl.Series.Add(series3);
            this.crtGraphControl.Size = new System.Drawing.Size(832, 360);
            this.crtGraphControl.TabIndex = 0;
            this.crtGraphControl.Text = "chart1";
            // 
            // pnlGraphControlControls
            // 
            this.pnlGraphControlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphControlControls.Controls.Add(this.flGraphControlControls);
            this.pnlGraphControlControls.Location = new System.Drawing.Point(842, 3);
            this.pnlGraphControlControls.Name = "pnlGraphControlControls";
            this.pnlGraphControlControls.Size = new System.Drawing.Size(200, 363);
            this.pnlGraphControlControls.TabIndex = 1;
            // 
            // flGraphControlControls
            // 
            this.flGraphControlControls.Controls.Add(this.pnlGraphControlUnits);
            this.flGraphControlControls.Controls.Add(this.pnlGraphControlDate);
            this.flGraphControlControls.Controls.Add(this.pnlGraphControlSession);
            this.flGraphControlControls.Controls.Add(this.pnlGraphControlButtons);
            this.flGraphControlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flGraphControlControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flGraphControlControls.Location = new System.Drawing.Point(0, 0);
            this.flGraphControlControls.Name = "flGraphControlControls";
            this.flGraphControlControls.Size = new System.Drawing.Size(200, 363);
            this.flGraphControlControls.TabIndex = 1;
            // 
            // pnlGraphControlUnits
            // 
            this.pnlGraphControlUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphControlUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphControlUnits.Controls.Add(this.cmbGraphControlUnits);
            this.pnlGraphControlUnits.Controls.Add(this.lblGraphControlUnits);
            this.pnlGraphControlUnits.Location = new System.Drawing.Point(3, 3);
            this.pnlGraphControlUnits.Name = "pnlGraphControlUnits";
            this.pnlGraphControlUnits.Size = new System.Drawing.Size(193, 111);
            this.pnlGraphControlUnits.TabIndex = 0;
            // 
            // cmbGraphControlUnits
            // 
            this.cmbGraphControlUnits.AutoResize = false;
            this.cmbGraphControlUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGraphControlUnits.Depth = 0;
            this.cmbGraphControlUnits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGraphControlUnits.DropDownHeight = 174;
            this.cmbGraphControlUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphControlUnits.DropDownWidth = 121;
            this.cmbGraphControlUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGraphControlUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGraphControlUnits.FormattingEnabled = true;
            this.cmbGraphControlUnits.IntegralHeight = false;
            this.cmbGraphControlUnits.ItemHeight = 43;
            this.cmbGraphControlUnits.Items.AddRange(new object[] {
            "Force",
            "Acceleration"});
            this.cmbGraphControlUnits.Location = new System.Drawing.Point(15, 39);
            this.cmbGraphControlUnits.MaxDropDownItems = 4;
            this.cmbGraphControlUnits.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGraphControlUnits.Name = "cmbGraphControlUnits";
            this.cmbGraphControlUnits.Size = new System.Drawing.Size(162, 49);
            this.cmbGraphControlUnits.StartIndex = 0;
            this.cmbGraphControlUnits.TabIndex = 2;
            // 
            // lblGraphControlUnits
            // 
            this.lblGraphControlUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraphControlUnits.Depth = 0;
            this.lblGraphControlUnits.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGraphControlUnits.Location = new System.Drawing.Point(15, 17);
            this.lblGraphControlUnits.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGraphControlUnits.Name = "lblGraphControlUnits";
            this.lblGraphControlUnits.Size = new System.Drawing.Size(157, 19);
            this.lblGraphControlUnits.TabIndex = 1;
            this.lblGraphControlUnits.Text = "Choose Unit";
            this.lblGraphControlUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraphControlDate
            // 
            this.pnlGraphControlDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphControlDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphControlDate.Controls.Add(this.lblGraphCOntrolDate);
            this.pnlGraphControlDate.Controls.Add(this.dtpGraphControlDate);
            this.pnlGraphControlDate.Location = new System.Drawing.Point(3, 120);
            this.pnlGraphControlDate.Name = "pnlGraphControlDate";
            this.pnlGraphControlDate.Size = new System.Drawing.Size(193, 53);
            this.pnlGraphControlDate.TabIndex = 1;
            // 
            // lblGraphCOntrolDate
            // 
            this.lblGraphCOntrolDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraphCOntrolDate.Depth = 0;
            this.lblGraphCOntrolDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGraphCOntrolDate.Location = new System.Drawing.Point(3, 0);
            this.lblGraphCOntrolDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGraphCOntrolDate.Name = "lblGraphCOntrolDate";
            this.lblGraphCOntrolDate.Size = new System.Drawing.Size(183, 19);
            this.lblGraphCOntrolDate.TabIndex = 1;
            this.lblGraphCOntrolDate.Text = "Set Date";
            this.lblGraphCOntrolDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpGraphControlDate
            // 
            this.dtpGraphControlDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpGraphControlDate.CustomFormat = "ddd dd\'/\'MM\'/\'yyyy";
            this.dtpGraphControlDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGraphControlDate.Location = new System.Drawing.Point(0, 22);
            this.dtpGraphControlDate.Name = "dtpGraphControlDate";
            this.dtpGraphControlDate.Size = new System.Drawing.Size(189, 20);
            this.dtpGraphControlDate.TabIndex = 0;
            // 
            // pnlGraphControlSession
            // 
            this.pnlGraphControlSession.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphControlSession.Controls.Add(this.cmbGraphControlSessions);
            this.pnlGraphControlSession.Controls.Add(this.lblGraphControlSessions);
            this.pnlGraphControlSession.Location = new System.Drawing.Point(3, 179);
            this.pnlGraphControlSession.Name = "pnlGraphControlSession";
            this.pnlGraphControlSession.Size = new System.Drawing.Size(193, 79);
            this.pnlGraphControlSession.TabIndex = 2;
            // 
            // cmbGraphControlSessions
            // 
            this.cmbGraphControlSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGraphControlSessions.AutoResize = false;
            this.cmbGraphControlSessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGraphControlSessions.Depth = 0;
            this.cmbGraphControlSessions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGraphControlSessions.DropDownHeight = 174;
            this.cmbGraphControlSessions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphControlSessions.DropDownWidth = 121;
            this.cmbGraphControlSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGraphControlSessions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGraphControlSessions.FormattingEnabled = true;
            this.cmbGraphControlSessions.IntegralHeight = false;
            this.cmbGraphControlSessions.ItemHeight = 43;
            this.cmbGraphControlSessions.Location = new System.Drawing.Point(15, 30);
            this.cmbGraphControlSessions.MaxDropDownItems = 4;
            this.cmbGraphControlSessions.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGraphControlSessions.Name = "cmbGraphControlSessions";
            this.cmbGraphControlSessions.Size = new System.Drawing.Size(159, 49);
            this.cmbGraphControlSessions.StartIndex = 0;
            this.cmbGraphControlSessions.TabIndex = 1;
            // 
            // lblGraphControlSessions
            // 
            this.lblGraphControlSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraphControlSessions.Depth = 0;
            this.lblGraphControlSessions.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGraphControlSessions.Location = new System.Drawing.Point(14, 8);
            this.lblGraphControlSessions.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGraphControlSessions.Name = "lblGraphControlSessions";
            this.lblGraphControlSessions.Size = new System.Drawing.Size(162, 19);
            this.lblGraphControlSessions.TabIndex = 0;
            this.lblGraphControlSessions.Text = "Choose Session";
            this.lblGraphControlSessions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraphControlButtons
            // 
            this.pnlGraphControlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphControlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphControlButtons.Controls.Add(this.btnGraphControlClear);
            this.pnlGraphControlButtons.Controls.Add(this.btnGraphControlGenerate);
            this.pnlGraphControlButtons.Location = new System.Drawing.Point(3, 264);
            this.pnlGraphControlButtons.Name = "pnlGraphControlButtons";
            this.pnlGraphControlButtons.Size = new System.Drawing.Size(193, 90);
            this.pnlGraphControlButtons.TabIndex = 2;
            // 
            // btnGraphControlClear
            // 
            this.btnGraphControlClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraphControlClear.AutoSize = false;
            this.btnGraphControlClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraphControlClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGraphControlClear.Depth = 0;
            this.btnGraphControlClear.HighEmphasis = true;
            this.btnGraphControlClear.Icon = null;
            this.btnGraphControlClear.Location = new System.Drawing.Point(18, 46);
            this.btnGraphControlClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGraphControlClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGraphControlClear.Name = "btnGraphControlClear";
            this.btnGraphControlClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGraphControlClear.Size = new System.Drawing.Size(154, 36);
            this.btnGraphControlClear.TabIndex = 1;
            this.btnGraphControlClear.Text = "Clear Graph";
            this.btnGraphControlClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGraphControlClear.UseAccentColor = false;
            this.btnGraphControlClear.UseVisualStyleBackColor = true;
            // 
            // btnGraphControlGenerate
            // 
            this.btnGraphControlGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraphControlGenerate.AutoSize = false;
            this.btnGraphControlGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraphControlGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGraphControlGenerate.Depth = 0;
            this.btnGraphControlGenerate.HighEmphasis = true;
            this.btnGraphControlGenerate.Icon = null;
            this.btnGraphControlGenerate.Location = new System.Drawing.Point(18, 6);
            this.btnGraphControlGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGraphControlGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGraphControlGenerate.Name = "btnGraphControlGenerate";
            this.btnGraphControlGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGraphControlGenerate.Size = new System.Drawing.Size(154, 36);
            this.btnGraphControlGenerate.TabIndex = 0;
            this.btnGraphControlGenerate.Text = "Generate Graph";
            this.btnGraphControlGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGraphControlGenerate.UseAccentColor = false;
            this.btnGraphControlGenerate.UseVisualStyleBackColor = true;
            // 
            // tsGraphView
            // 
            this.tsGraphView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsGraphView.BaseTabControl = this.tabsGraphView;
            this.tsGraphView.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tsGraphView.Depth = 0;
            this.tsGraphView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tsGraphView.Location = new System.Drawing.Point(-2, 0);
            this.tsGraphView.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsGraphView.Name = "tsGraphView";
            this.tsGraphView.Size = new System.Drawing.Size(1073, 37);
            this.tsGraphView.TabIndex = 3;
            this.tsGraphView.Text = "materialTabSelector1";
            // 
            // pnlClose
            // 
            this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClose.Controls.Add(this.btnGraphClose);
            this.pnlClose.Location = new System.Drawing.Point(977, 440);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(79, 47);
            this.pnlClose.TabIndex = 2;
            // 
            // btnGraphClose
            // 
            this.btnGraphClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraphClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraphClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGraphClose.Depth = 0;
            this.btnGraphClose.HighEmphasis = true;
            this.btnGraphClose.Icon = null;
            this.btnGraphClose.Location = new System.Drawing.Point(9, 8);
            this.btnGraphClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGraphClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGraphClose.Name = "btnGraphClose";
            this.btnGraphClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGraphClose.Size = new System.Drawing.Size(66, 36);
            this.btnGraphClose.TabIndex = 1;
            this.btnGraphClose.Text = "Close";
            this.btnGraphClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGraphClose.UseAccentColor = false;
            this.btnGraphClose.UseVisualStyleBackColor = true;
            this.btnGraphClose.Click += new System.EventHandler(this.btnGraphClose_Click);
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.tsStats);
            this.tabStatistics.Controls.Add(this.tabsStatistics);
            this.tabStatistics.ImageKey = "Statistics.png";
            this.tabStatistics.Location = new System.Drawing.Point(4, 39);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(1059, 490);
            this.tabStatistics.TabIndex = 2;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // tsStats
            // 
            this.tsStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsStats.BaseTabControl = this.tabsStatistics;
            this.tsStats.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tsStats.Depth = 0;
            this.tsStats.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tsStats.Location = new System.Drawing.Point(-4, 0);
            this.tsStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsStats.Name = "tsStats";
            this.tsStats.Size = new System.Drawing.Size(1073, 37);
            this.tsStats.TabIndex = 3;
            this.tsStats.Text = "materialTabSelector1";
            // 
            // tabsStatistics
            // 
            this.tabsStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsStatistics.Controls.Add(this.tabStatsMain);
            this.tabsStatistics.Controls.Add(this.tabStatsHitCounter);
            this.tabsStatistics.Controls.Add(this.tabStatsControl);
            this.tabsStatistics.Depth = 0;
            this.tabsStatistics.Location = new System.Drawing.Point(3, 37);
            this.tabsStatistics.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabsStatistics.Multiline = true;
            this.tabsStatistics.Name = "tabsStatistics";
            this.tabsStatistics.SelectedIndex = 0;
            this.tabsStatistics.Size = new System.Drawing.Size(1056, 453);
            this.tabsStatistics.TabIndex = 2;
            // 
            // tabStatsMain
            // 
            this.tabStatsMain.Controls.Add(this.pnlStatsMainListView);
            this.tabStatsMain.Controls.Add(this.pnlStatsMainButtons);
            this.tabStatsMain.Controls.Add(this.pnlStatsButtons);
            this.tabStatsMain.ImageKey = "home.png";
            this.tabStatsMain.Location = new System.Drawing.Point(4, 22);
            this.tabStatsMain.Name = "tabStatsMain";
            this.tabStatsMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatsMain.Size = new System.Drawing.Size(1048, 427);
            this.tabStatsMain.TabIndex = 0;
            this.tabStatsMain.Text = "Main";
            this.tabStatsMain.UseVisualStyleBackColor = true;
            // 
            // pnlStatsMainListView
            // 
            this.pnlStatsMainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsMainListView.Controls.Add(this.dgvStatsMain);
            this.pnlStatsMainListView.Location = new System.Drawing.Point(54, 6);
            this.pnlStatsMainListView.Name = "pnlStatsMainListView";
            this.pnlStatsMainListView.Size = new System.Drawing.Size(719, 415);
            this.pnlStatsMainListView.TabIndex = 3;
            // 
            // dgvStatsMain
            // 
            this.dgvStatsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatsMain.Location = new System.Drawing.Point(0, 0);
            this.dgvStatsMain.Name = "dgvStatsMain";
            this.dgvStatsMain.ReadOnly = true;
            this.dgvStatsMain.Size = new System.Drawing.Size(719, 415);
            this.dgvStatsMain.TabIndex = 0;
            // 
            // pnlStatsMainButtons
            // 
            this.pnlStatsMainButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsMainButtons.Controls.Add(this.btnStatsMainClear);
            this.pnlStatsMainButtons.Controls.Add(this.btnStatsMainGenerate);
            this.pnlStatsMainButtons.Controls.Add(this.dtpStatsMainDate);
            this.pnlStatsMainButtons.Controls.Add(this.lblStatsMainDate);
            this.pnlStatsMainButtons.Location = new System.Drawing.Point(812, 3);
            this.pnlStatsMainButtons.Name = "pnlStatsMainButtons";
            this.pnlStatsMainButtons.Size = new System.Drawing.Size(233, 364);
            this.pnlStatsMainButtons.TabIndex = 2;
            // 
            // btnStatsMainClear
            // 
            this.btnStatsMainClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsMainClear.AutoSize = false;
            this.btnStatsMainClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsMainClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsMainClear.Depth = 0;
            this.btnStatsMainClear.HighEmphasis = true;
            this.btnStatsMainClear.Icon = null;
            this.btnStatsMainClear.Location = new System.Drawing.Point(30, 110);
            this.btnStatsMainClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatsMainClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatsMainClear.Name = "btnStatsMainClear";
            this.btnStatsMainClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatsMainClear.Size = new System.Drawing.Size(175, 36);
            this.btnStatsMainClear.TabIndex = 3;
            this.btnStatsMainClear.Text = "Clear Report";
            this.btnStatsMainClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatsMainClear.UseAccentColor = false;
            this.btnStatsMainClear.UseVisualStyleBackColor = true;
            this.btnStatsMainClear.Click += new System.EventHandler(this.btnStatsMainClear_Click);
            // 
            // btnStatsMainGenerate
            // 
            this.btnStatsMainGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsMainGenerate.AutoSize = false;
            this.btnStatsMainGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsMainGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsMainGenerate.Depth = 0;
            this.btnStatsMainGenerate.HighEmphasis = true;
            this.btnStatsMainGenerate.Icon = null;
            this.btnStatsMainGenerate.Location = new System.Drawing.Point(30, 64);
            this.btnStatsMainGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatsMainGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatsMainGenerate.Name = "btnStatsMainGenerate";
            this.btnStatsMainGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatsMainGenerate.Size = new System.Drawing.Size(175, 36);
            this.btnStatsMainGenerate.TabIndex = 2;
            this.btnStatsMainGenerate.Text = "Generate Report";
            this.btnStatsMainGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatsMainGenerate.UseAccentColor = false;
            this.btnStatsMainGenerate.UseVisualStyleBackColor = true;
            this.btnStatsMainGenerate.Click += new System.EventHandler(this.btnStatsMainGenerate_Click);
            // 
            // dtpStatsMainDate
            // 
            this.dtpStatsMainDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStatsMainDate.Location = new System.Drawing.Point(3, 35);
            this.dtpStatsMainDate.Name = "dtpStatsMainDate";
            this.dtpStatsMainDate.Size = new System.Drawing.Size(226, 20);
            this.dtpStatsMainDate.TabIndex = 1;
            // 
            // lblStatsMainDate
            // 
            this.lblStatsMainDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatsMainDate.Depth = 0;
            this.lblStatsMainDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStatsMainDate.Location = new System.Drawing.Point(3, 13);
            this.lblStatsMainDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatsMainDate.Name = "lblStatsMainDate";
            this.lblStatsMainDate.Size = new System.Drawing.Size(226, 19);
            this.lblStatsMainDate.TabIndex = 0;
            this.lblStatsMainDate.Text = "Select Date";
            this.lblStatsMainDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStatsButtons
            // 
            this.pnlStatsButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsButtons.Controls.Add(this.btnStatsClose);
            this.pnlStatsButtons.Location = new System.Drawing.Point(957, 373);
            this.pnlStatsButtons.Name = "pnlStatsButtons";
            this.pnlStatsButtons.Size = new System.Drawing.Size(88, 51);
            this.pnlStatsButtons.TabIndex = 1;
            // 
            // btnStatsClose
            // 
            this.btnStatsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsClose.Depth = 0;
            this.btnStatsClose.HighEmphasis = true;
            this.btnStatsClose.Icon = null;
            this.btnStatsClose.Location = new System.Drawing.Point(18, 12);
            this.btnStatsClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatsClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatsClose.Name = "btnStatsClose";
            this.btnStatsClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatsClose.Size = new System.Drawing.Size(66, 36);
            this.btnStatsClose.TabIndex = 0;
            this.btnStatsClose.Text = "Close";
            this.btnStatsClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatsClose.UseAccentColor = false;
            this.btnStatsClose.UseVisualStyleBackColor = true;
            this.btnStatsClose.Click += new System.EventHandler(this.btnStatsClose_Click);
            // 
            // tabStatsHitCounter
            // 
            this.tabStatsHitCounter.Controls.Add(this.pnlStatsHitCounter);
            this.tabStatsHitCounter.Controls.Add(this.pnlStatsHitCounterControls);
            this.tabStatsHitCounter.Controls.Add(this.pnlStatsHitCounterClose);
            this.tabStatsHitCounter.ImageKey = "Hit Counter.png";
            this.tabStatsHitCounter.Location = new System.Drawing.Point(4, 22);
            this.tabStatsHitCounter.Name = "tabStatsHitCounter";
            this.tabStatsHitCounter.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatsHitCounter.Size = new System.Drawing.Size(1048, 427);
            this.tabStatsHitCounter.TabIndex = 1;
            this.tabStatsHitCounter.Text = "Hit Counter";
            this.tabStatsHitCounter.UseVisualStyleBackColor = true;
            // 
            // pnlStatsHitCounter
            // 
            this.pnlStatsHitCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsHitCounter.Controls.Add(this.dgvStatsHitCounter);
            this.pnlStatsHitCounter.Location = new System.Drawing.Point(54, 6);
            this.pnlStatsHitCounter.Name = "pnlStatsHitCounter";
            this.pnlStatsHitCounter.Size = new System.Drawing.Size(719, 415);
            this.pnlStatsHitCounter.TabIndex = 5;
            // 
            // dgvStatsHitCounter
            // 
            this.dgvStatsHitCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsHitCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatsHitCounter.Location = new System.Drawing.Point(0, 0);
            this.dgvStatsHitCounter.Name = "dgvStatsHitCounter";
            this.dgvStatsHitCounter.ReadOnly = true;
            this.dgvStatsHitCounter.Size = new System.Drawing.Size(719, 415);
            this.dgvStatsHitCounter.TabIndex = 0;
            // 
            // pnlStatsHitCounterControls
            // 
            this.pnlStatsHitCounterControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsHitCounterControls.Controls.Add(this.btnStatsHitCounterClear);
            this.pnlStatsHitCounterControls.Controls.Add(this.btnStatsHitCounterGenerate);
            this.pnlStatsHitCounterControls.Controls.Add(this.dtpStatsHitCounterDate);
            this.pnlStatsHitCounterControls.Controls.Add(this.lblStatsHitCounterDate);
            this.pnlStatsHitCounterControls.Location = new System.Drawing.Point(812, 3);
            this.pnlStatsHitCounterControls.Name = "pnlStatsHitCounterControls";
            this.pnlStatsHitCounterControls.Size = new System.Drawing.Size(233, 364);
            this.pnlStatsHitCounterControls.TabIndex = 4;
            // 
            // btnStatsHitCounterClear
            // 
            this.btnStatsHitCounterClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsHitCounterClear.AutoSize = false;
            this.btnStatsHitCounterClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsHitCounterClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsHitCounterClear.Depth = 0;
            this.btnStatsHitCounterClear.HighEmphasis = true;
            this.btnStatsHitCounterClear.Icon = null;
            this.btnStatsHitCounterClear.Location = new System.Drawing.Point(30, 110);
            this.btnStatsHitCounterClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatsHitCounterClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatsHitCounterClear.Name = "btnStatsHitCounterClear";
            this.btnStatsHitCounterClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatsHitCounterClear.Size = new System.Drawing.Size(175, 36);
            this.btnStatsHitCounterClear.TabIndex = 3;
            this.btnStatsHitCounterClear.Text = "Clear Report";
            this.btnStatsHitCounterClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatsHitCounterClear.UseAccentColor = false;
            this.btnStatsHitCounterClear.UseVisualStyleBackColor = true;
            this.btnStatsHitCounterClear.Click += new System.EventHandler(this.btnStatsHitCounterClear_Click);
            // 
            // btnStatsHitCounterGenerate
            // 
            this.btnStatsHitCounterGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsHitCounterGenerate.AutoSize = false;
            this.btnStatsHitCounterGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsHitCounterGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsHitCounterGenerate.Depth = 0;
            this.btnStatsHitCounterGenerate.HighEmphasis = true;
            this.btnStatsHitCounterGenerate.Icon = null;
            this.btnStatsHitCounterGenerate.Location = new System.Drawing.Point(30, 64);
            this.btnStatsHitCounterGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatsHitCounterGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatsHitCounterGenerate.Name = "btnStatsHitCounterGenerate";
            this.btnStatsHitCounterGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatsHitCounterGenerate.Size = new System.Drawing.Size(175, 36);
            this.btnStatsHitCounterGenerate.TabIndex = 2;
            this.btnStatsHitCounterGenerate.Text = "Generate Report";
            this.btnStatsHitCounterGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatsHitCounterGenerate.UseAccentColor = false;
            this.btnStatsHitCounterGenerate.UseVisualStyleBackColor = true;
            this.btnStatsHitCounterGenerate.Click += new System.EventHandler(this.btnStatsHitCounterGenerate_Click);
            // 
            // dtpStatsHitCounterDate
            // 
            this.dtpStatsHitCounterDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStatsHitCounterDate.Location = new System.Drawing.Point(3, 35);
            this.dtpStatsHitCounterDate.Name = "dtpStatsHitCounterDate";
            this.dtpStatsHitCounterDate.Size = new System.Drawing.Size(226, 20);
            this.dtpStatsHitCounterDate.TabIndex = 1;
            // 
            // lblStatsHitCounterDate
            // 
            this.lblStatsHitCounterDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatsHitCounterDate.Depth = 0;
            this.lblStatsHitCounterDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStatsHitCounterDate.Location = new System.Drawing.Point(3, 13);
            this.lblStatsHitCounterDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatsHitCounterDate.Name = "lblStatsHitCounterDate";
            this.lblStatsHitCounterDate.Size = new System.Drawing.Size(226, 19);
            this.lblStatsHitCounterDate.TabIndex = 0;
            this.lblStatsHitCounterDate.Text = "Select Date";
            this.lblStatsHitCounterDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStatsHitCounterClose
            // 
            this.pnlStatsHitCounterClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsHitCounterClose.Controls.Add(this.btnStatsHitCounterClose);
            this.pnlStatsHitCounterClose.Location = new System.Drawing.Point(954, 370);
            this.pnlStatsHitCounterClose.Name = "pnlStatsHitCounterClose";
            this.pnlStatsHitCounterClose.Size = new System.Drawing.Size(88, 51);
            this.pnlStatsHitCounterClose.TabIndex = 2;
            // 
            // btnStatsHitCounterClose
            // 
            this.btnStatsHitCounterClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsHitCounterClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsHitCounterClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsHitCounterClose.Depth = 0;
            this.btnStatsHitCounterClose.HighEmphasis = true;
            this.btnStatsHitCounterClose.Icon = null;
            this.btnStatsHitCounterClose.Location = new System.Drawing.Point(18, 12);
            this.btnStatsHitCounterClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatsHitCounterClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatsHitCounterClose.Name = "btnStatsHitCounterClose";
            this.btnStatsHitCounterClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatsHitCounterClose.Size = new System.Drawing.Size(66, 36);
            this.btnStatsHitCounterClose.TabIndex = 0;
            this.btnStatsHitCounterClose.Text = "Close";
            this.btnStatsHitCounterClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatsHitCounterClose.UseAccentColor = false;
            this.btnStatsHitCounterClose.UseVisualStyleBackColor = true;
            this.btnStatsHitCounterClose.Click += new System.EventHandler(this.btnStatsHitCounterClose_Click);
            // 
            // tabStatsControl
            // 
            this.tabStatsControl.Controls.Add(this.pnlStatsControl);
            this.tabStatsControl.Controls.Add(this.pnlStatsControlControls);
            this.tabStatsControl.Controls.Add(this.pnlStatsControlClose);
            this.tabStatsControl.ImageKey = "Control.png";
            this.tabStatsControl.Location = new System.Drawing.Point(4, 22);
            this.tabStatsControl.Name = "tabStatsControl";
            this.tabStatsControl.Size = new System.Drawing.Size(1048, 427);
            this.tabStatsControl.TabIndex = 2;
            this.tabStatsControl.Text = "Control";
            this.tabStatsControl.UseVisualStyleBackColor = true;
            // 
            // pnlStatsControl
            // 
            this.pnlStatsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsControl.Controls.Add(this.dgvStatsControl);
            this.pnlStatsControl.Location = new System.Drawing.Point(54, 6);
            this.pnlStatsControl.Name = "pnlStatsControl";
            this.pnlStatsControl.Size = new System.Drawing.Size(719, 415);
            this.pnlStatsControl.TabIndex = 5;
            // 
            // dgvStatsControl
            // 
            this.dgvStatsControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatsControl.Location = new System.Drawing.Point(0, 0);
            this.dgvStatsControl.Name = "dgvStatsControl";
            this.dgvStatsControl.ReadOnly = true;
            this.dgvStatsControl.Size = new System.Drawing.Size(719, 415);
            this.dgvStatsControl.TabIndex = 0;
            // 
            // pnlStatsControlControls
            // 
            this.pnlStatsControlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsControlControls.Controls.Add(this.btnStatsControlClear);
            this.pnlStatsControlControls.Controls.Add(this.btnStatsControlGenerate);
            this.pnlStatsControlControls.Controls.Add(this.dtpStatsControlDate);
            this.pnlStatsControlControls.Controls.Add(this.materialLabel2);
            this.pnlStatsControlControls.Location = new System.Drawing.Point(812, 3);
            this.pnlStatsControlControls.Name = "pnlStatsControlControls";
            this.pnlStatsControlControls.Size = new System.Drawing.Size(233, 364);
            this.pnlStatsControlControls.TabIndex = 4;
            // 
            // btnStatsControlClear
            // 
            this.btnStatsControlClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsControlClear.AutoSize = false;
            this.btnStatsControlClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsControlClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsControlClear.Depth = 0;
            this.btnStatsControlClear.HighEmphasis = true;
            this.btnStatsControlClear.Icon = null;
            this.btnStatsControlClear.Location = new System.Drawing.Point(30, 110);
            this.btnStatsControlClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatsControlClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatsControlClear.Name = "btnStatsControlClear";
            this.btnStatsControlClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatsControlClear.Size = new System.Drawing.Size(175, 36);
            this.btnStatsControlClear.TabIndex = 3;
            this.btnStatsControlClear.Text = "Clear Report";
            this.btnStatsControlClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatsControlClear.UseAccentColor = false;
            this.btnStatsControlClear.UseVisualStyleBackColor = true;
            this.btnStatsControlClear.Click += new System.EventHandler(this.btnStatsControlClear_Click);
            // 
            // btnStatsControlGenerate
            // 
            this.btnStatsControlGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsControlGenerate.AutoSize = false;
            this.btnStatsControlGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsControlGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsControlGenerate.Depth = 0;
            this.btnStatsControlGenerate.HighEmphasis = true;
            this.btnStatsControlGenerate.Icon = null;
            this.btnStatsControlGenerate.Location = new System.Drawing.Point(30, 64);
            this.btnStatsControlGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatsControlGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatsControlGenerate.Name = "btnStatsControlGenerate";
            this.btnStatsControlGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatsControlGenerate.Size = new System.Drawing.Size(175, 36);
            this.btnStatsControlGenerate.TabIndex = 2;
            this.btnStatsControlGenerate.Text = "Generate Report";
            this.btnStatsControlGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatsControlGenerate.UseAccentColor = false;
            this.btnStatsControlGenerate.UseVisualStyleBackColor = true;
            this.btnStatsControlGenerate.Click += new System.EventHandler(this.btnStatsControlGenerate_Click);
            // 
            // dtpStatsControlDate
            // 
            this.dtpStatsControlDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStatsControlDate.Location = new System.Drawing.Point(3, 35);
            this.dtpStatsControlDate.Name = "dtpStatsControlDate";
            this.dtpStatsControlDate.Size = new System.Drawing.Size(226, 20);
            this.dtpStatsControlDate.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(3, 13);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(226, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Select Date";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStatsControlClose
            // 
            this.pnlStatsControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsControlClose.Controls.Add(this.btnStatsControlClose);
            this.pnlStatsControlClose.Location = new System.Drawing.Point(957, 373);
            this.pnlStatsControlClose.Name = "pnlStatsControlClose";
            this.pnlStatsControlClose.Size = new System.Drawing.Size(88, 51);
            this.pnlStatsControlClose.TabIndex = 3;
            // 
            // btnStatsControlClose
            // 
            this.btnStatsControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsControlClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsControlClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsControlClose.Depth = 0;
            this.btnStatsControlClose.HighEmphasis = true;
            this.btnStatsControlClose.Icon = null;
            this.btnStatsControlClose.Location = new System.Drawing.Point(18, 12);
            this.btnStatsControlClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatsControlClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatsControlClose.Name = "btnStatsControlClose";
            this.btnStatsControlClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatsControlClose.Size = new System.Drawing.Size(66, 36);
            this.btnStatsControlClose.TabIndex = 0;
            this.btnStatsControlClose.Text = "Close";
            this.btnStatsControlClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStatsControlClose.UseAccentColor = false;
            this.btnStatsControlClose.UseVisualStyleBackColor = true;
            this.btnStatsControlClose.Click += new System.EventHandler(this.btnStatsControlClose_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.pnlChoosePort);
            this.tabSettings.Controls.Add(this.pnlDBCheck);
            this.tabSettings.Controls.Add(this.pnlSettingsClose);
            this.tabSettings.Controls.Add(this.pnlMassInput);
            this.tabSettings.Controls.Add(this.pnlCheck);
            this.tabSettings.Controls.Add(this.pnlTheme);
            this.tabSettings.ImageKey = "Settings.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1059, 490);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // pnlChoosePort
            // 
            this.pnlChoosePort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChoosePort.Controls.Add(this.btnRefreshPorts);
            this.pnlChoosePort.Controls.Add(this.txtCurrentPort);
            this.pnlChoosePort.Controls.Add(this.lblCurrentPort);
            this.pnlChoosePort.Controls.Add(this.btnOpenPort);
            this.pnlChoosePort.Controls.Add(this.cmbPorts);
            this.pnlChoosePort.Controls.Add(this.lblChoosePort);
            this.pnlChoosePort.Location = new System.Drawing.Point(469, 15);
            this.pnlChoosePort.Name = "pnlChoosePort";
            this.pnlChoosePort.Size = new System.Drawing.Size(200, 352);
            this.pnlChoosePort.TabIndex = 9;
            // 
            // txtCurrentPort
            // 
            this.txtCurrentPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentPort.AnimateReadOnly = false;
            this.txtCurrentPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPort.Depth = 0;
            this.txtCurrentPort.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCurrentPort.LeadingIcon = null;
            this.txtCurrentPort.Location = new System.Drawing.Point(25, 40);
            this.txtCurrentPort.MaxLength = 50;
            this.txtCurrentPort.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCurrentPort.Multiline = false;
            this.txtCurrentPort.Name = "txtCurrentPort";
            this.txtCurrentPort.ReadOnly = true;
            this.txtCurrentPort.Size = new System.Drawing.Size(149, 50);
            this.txtCurrentPort.TabIndex = 4;
            this.txtCurrentPort.Text = "";
            this.txtCurrentPort.TrailingIcon = null;
            // 
            // lblCurrentPort
            // 
            this.lblCurrentPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPort.Depth = 0;
            this.lblCurrentPort.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentPort.Location = new System.Drawing.Point(22, 13);
            this.lblCurrentPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentPort.Name = "lblCurrentPort";
            this.lblCurrentPort.Size = new System.Drawing.Size(152, 19);
            this.lblCurrentPort.TabIndex = 3;
            this.lblCurrentPort.Text = "Current Port";
            this.lblCurrentPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPort.AutoSize = false;
            this.btnOpenPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenPort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenPort.Depth = 0;
            this.btnOpenPort.HighEmphasis = true;
            this.btnOpenPort.Icon = null;
            this.btnOpenPort.Location = new System.Drawing.Point(20, 299);
            this.btnOpenPort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenPort.Size = new System.Drawing.Size(154, 36);
            this.btnOpenPort.TabIndex = 2;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenPort.UseAccentColor = false;
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // cmbPorts
            // 
            this.cmbPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPorts.AutoResize = false;
            this.cmbPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPorts.Depth = 0;
            this.cmbPorts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPorts.DropDownHeight = 174;
            this.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorts.DropDownWidth = 121;
            this.cmbPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Hint = "Port Name";
            this.cmbPorts.IntegralHeight = false;
            this.cmbPorts.ItemHeight = 43;
            this.cmbPorts.Location = new System.Drawing.Point(20, 183);
            this.cmbPorts.MaxDropDownItems = 4;
            this.cmbPorts.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(154, 49);
            this.cmbPorts.StartIndex = 0;
            this.cmbPorts.TabIndex = 1;
            // 
            // lblChoosePort
            // 
            this.lblChoosePort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChoosePort.Depth = 0;
            this.lblChoosePort.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblChoosePort.Location = new System.Drawing.Point(19, 129);
            this.lblChoosePort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChoosePort.Name = "lblChoosePort";
            this.lblChoosePort.Size = new System.Drawing.Size(155, 42);
            this.lblChoosePort.TabIndex = 0;
            this.lblChoosePort.Text = "Choose Port";
            this.lblChoosePort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDBCheck
            // 
            this.pnlDBCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDBCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDBCheck.Controls.Add(this.btnDBCheck);
            this.pnlDBCheck.Controls.Add(this.lblDBCheck);
            this.pnlDBCheck.Location = new System.Drawing.Point(244, 269);
            this.pnlDBCheck.Name = "pnlDBCheck";
            this.pnlDBCheck.Size = new System.Drawing.Size(200, 125);
            this.pnlDBCheck.TabIndex = 8;
            // 
            // btnDBCheck
            // 
            this.btnDBCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDBCheck.AutoSize = false;
            this.btnDBCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDBCheck.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDBCheck.Depth = 0;
            this.btnDBCheck.HighEmphasis = true;
            this.btnDBCheck.Icon = null;
            this.btnDBCheck.Location = new System.Drawing.Point(20, 58);
            this.btnDBCheck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDBCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDBCheck.Name = "btnDBCheck";
            this.btnDBCheck.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDBCheck.Size = new System.Drawing.Size(163, 38);
            this.btnDBCheck.TabIndex = 1;
            this.btnDBCheck.Text = "Check DB Connection";
            this.btnDBCheck.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDBCheck.UseAccentColor = false;
            this.btnDBCheck.UseVisualStyleBackColor = true;
            this.btnDBCheck.Click += new System.EventHandler(this.btnDBCheck_Click);
            // 
            // lblDBCheck
            // 
            this.lblDBCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDBCheck.Depth = 0;
            this.lblDBCheck.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDBCheck.Location = new System.Drawing.Point(20, 21);
            this.lblDBCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDBCheck.Name = "lblDBCheck";
            this.lblDBCheck.Size = new System.Drawing.Size(163, 19);
            this.lblDBCheck.TabIndex = 0;
            this.lblDBCheck.Text = "Check DB Connection";
            this.lblDBCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSettingsClose
            // 
            this.pnlSettingsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettingsClose.Controls.Add(this.btnSettingsClose);
            this.pnlSettingsClose.Location = new System.Drawing.Point(970, 436);
            this.pnlSettingsClose.Name = "pnlSettingsClose";
            this.pnlSettingsClose.Size = new System.Drawing.Size(86, 51);
            this.pnlSettingsClose.TabIndex = 7;
            // 
            // btnSettingsClose
            // 
            this.btnSettingsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettingsClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSettingsClose.Depth = 0;
            this.btnSettingsClose.HighEmphasis = true;
            this.btnSettingsClose.Icon = null;
            this.btnSettingsClose.Location = new System.Drawing.Point(16, 12);
            this.btnSettingsClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSettingsClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettingsClose.Name = "btnSettingsClose";
            this.btnSettingsClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSettingsClose.Size = new System.Drawing.Size(66, 36);
            this.btnSettingsClose.TabIndex = 0;
            this.btnSettingsClose.Text = "Close";
            this.btnSettingsClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSettingsClose.UseAccentColor = false;
            this.btnSettingsClose.UseVisualStyleBackColor = true;
            this.btnSettingsClose.Click += new System.EventHandler(this.btnSettingsClose_Click);
            // 
            // pnlMassInput
            // 
            this.pnlMassInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMassInput.Controls.Add(this.txtCurrentMass);
            this.pnlMassInput.Controls.Add(this.lblCurrentMass);
            this.pnlMassInput.Controls.Add(this.btnChangeMass);
            this.pnlMassInput.Controls.Add(this.lblMass);
            this.pnlMassInput.Controls.Add(this.txtMassInput);
            this.pnlMassInput.Location = new System.Drawing.Point(244, 15);
            this.pnlMassInput.Name = "pnlMassInput";
            this.pnlMassInput.Size = new System.Drawing.Size(200, 247);
            this.pnlMassInput.TabIndex = 6;
            // 
            // txtCurrentMass
            // 
            this.txtCurrentMass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentMass.AnimateReadOnly = false;
            this.txtCurrentMass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentMass.Depth = 0;
            this.txtCurrentMass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCurrentMass.LeadingIcon = null;
            this.txtCurrentMass.Location = new System.Drawing.Point(23, 40);
            this.txtCurrentMass.MaxLength = 50;
            this.txtCurrentMass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCurrentMass.Multiline = false;
            this.txtCurrentMass.Name = "txtCurrentMass";
            this.txtCurrentMass.ReadOnly = true;
            this.txtCurrentMass.Size = new System.Drawing.Size(160, 50);
            this.txtCurrentMass.TabIndex = 4;
            this.txtCurrentMass.Text = "";
            this.txtCurrentMass.TrailingIcon = null;
            // 
            // lblCurrentMass
            // 
            this.lblCurrentMass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentMass.Depth = 0;
            this.lblCurrentMass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentMass.Location = new System.Drawing.Point(20, 13);
            this.lblCurrentMass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentMass.Name = "lblCurrentMass";
            this.lblCurrentMass.Size = new System.Drawing.Size(163, 23);
            this.lblCurrentMass.TabIndex = 3;
            this.lblCurrentMass.Text = "Current Mass";
            this.lblCurrentMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangeMass
            // 
            this.btnChangeMass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeMass.AutoSize = false;
            this.btnChangeMass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeMass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangeMass.Depth = 0;
            this.btnChangeMass.HighEmphasis = true;
            this.btnChangeMass.Icon = null;
            this.btnChangeMass.Location = new System.Drawing.Point(20, 196);
            this.btnChangeMass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeMass.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeMass.Name = "btnChangeMass";
            this.btnChangeMass.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangeMass.Size = new System.Drawing.Size(167, 36);
            this.btnChangeMass.TabIndex = 2;
            this.btnChangeMass.Text = "Change Mass";
            this.btnChangeMass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangeMass.UseAccentColor = false;
            this.btnChangeMass.UseVisualStyleBackColor = true;
            this.btnChangeMass.Click += new System.EventHandler(this.btnChangeMass_Click);
            // 
            // lblMass
            // 
            this.lblMass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMass.Depth = 0;
            this.lblMass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMass.Location = new System.Drawing.Point(20, 117);
            this.lblMass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(163, 19);
            this.lblMass.TabIndex = 1;
            this.lblMass.Text = "Change Mass";
            this.lblMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMassInput
            // 
            this.txtMassInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMassInput.AnimateReadOnly = false;
            this.txtMassInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMassInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMassInput.Depth = 0;
            this.txtMassInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMassInput.HideSelection = true;
            this.txtMassInput.Hint = "Input Mass Here";
            this.txtMassInput.LeadingIcon = null;
            this.txtMassInput.Location = new System.Drawing.Point(20, 139);
            this.txtMassInput.MaxLength = 32767;
            this.txtMassInput.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMassInput.Name = "txtMassInput";
            this.txtMassInput.PasswordChar = '\0';
            this.txtMassInput.PrefixSuffixText = null;
            this.txtMassInput.ReadOnly = false;
            this.txtMassInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMassInput.SelectedText = "";
            this.txtMassInput.SelectionLength = 0;
            this.txtMassInput.SelectionStart = 0;
            this.txtMassInput.ShortcutsEnabled = true;
            this.txtMassInput.Size = new System.Drawing.Size(163, 48);
            this.txtMassInput.TabIndex = 0;
            this.txtMassInput.TabStop = false;
            this.txtMassInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMassInput.TrailingIcon = null;
            this.txtMassInput.UseSystemPasswordChar = false;
            // 
            // pnlCheck
            // 
            this.pnlCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCheck.Controls.Add(this.btnCheck);
            this.pnlCheck.Controls.Add(this.lblCheck);
            this.pnlCheck.Location = new System.Drawing.Point(16, 269);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(200, 104);
            this.pnlCheck.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.AutoSize = false;
            this.btnCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheck.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheck.Depth = 0;
            this.btnCheck.HighEmphasis = true;
            this.btnCheck.Icon = null;
            this.btnCheck.Location = new System.Drawing.Point(39, 39);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheck.Size = new System.Drawing.Size(129, 42);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheck.UseAccentColor = false;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheck.AutoSize = true;
            this.lblCheck.Depth = 0;
            this.lblCheck.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCheck.Location = new System.Drawing.Point(40, 14);
            this.lblCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(128, 19);
            this.lblCheck.TabIndex = 0;
            this.lblCheck.Text = "Check Connection";
            this.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTheme
            // 
            this.pnlTheme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTheme.Controls.Add(this.lblTheme);
            this.pnlTheme.Controls.Add(this.btnDark);
            this.pnlTheme.Controls.Add(this.btnLight);
            this.pnlTheme.Location = new System.Drawing.Point(16, 15);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.Size = new System.Drawing.Size(200, 151);
            this.pnlTheme.TabIndex = 4;
            // 
            // lblTheme
            // 
            this.lblTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTheme.Depth = 0;
            this.lblTheme.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTheme.Location = new System.Drawing.Point(39, 13);
            this.lblTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(125, 19);
            this.lblTheme.TabIndex = 3;
            this.lblTheme.Text = "Change Theme";
            this.lblTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDark
            // 
            this.btnDark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDark.AutoSize = false;
            this.btnDark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDark.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDark.Depth = 0;
            this.btnDark.HighEmphasis = true;
            this.btnDark.Icon = null;
            this.btnDark.Location = new System.Drawing.Point(39, 86);
            this.btnDark.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDark.MaximumSize = new System.Drawing.Size(200, 200);
            this.btnDark.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDark.Name = "btnDark";
            this.btnDark.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDark.Size = new System.Drawing.Size(129, 36);
            this.btnDark.TabIndex = 2;
            this.btnDark.Text = "Dark";
            this.btnDark.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDark.UseAccentColor = false;
            this.btnDark.UseVisualStyleBackColor = true;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // btnLight
            // 
            this.btnLight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLight.AutoSize = false;
            this.btnLight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLight.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLight.Depth = 0;
            this.btnLight.HighEmphasis = true;
            this.btnLight.Icon = null;
            this.btnLight.Location = new System.Drawing.Point(39, 38);
            this.btnLight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLight.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLight.Name = "btnLight";
            this.btnLight.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLight.Size = new System.Drawing.Size(129, 36);
            this.btnLight.TabIndex = 1;
            this.btnLight.Text = "Light";
            this.btnLight.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLight.UseAccentColor = false;
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Graph.png");
            this.imgList.Images.SetKeyName(1, "home.png");
            this.imgList.Images.SetKeyName(2, "Settings.png");
            this.imgList.Images.SetKeyName(3, "Statistics.png");
            this.imgList.Images.SetKeyName(4, "Hit Counter.png");
            this.imgList.Images.SetKeyName(5, "Control.png");
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshPorts.AutoSize = false;
            this.btnRefreshPorts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefreshPorts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefreshPorts.Depth = 0;
            this.btnRefreshPorts.HighEmphasis = true;
            this.btnRefreshPorts.Icon = null;
            this.btnRefreshPorts.Location = new System.Drawing.Point(20, 252);
            this.btnRefreshPorts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefreshPorts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefreshPorts.Size = new System.Drawing.Size(154, 36);
            this.btnRefreshPorts.TabIndex = 5;
            this.btnRefreshPorts.Text = "Refresh Ports";
            this.btnRefreshPorts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefreshPorts.UseAccentColor = false;
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 600);
            this.Controls.Add(this.tabs);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabs;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Text = "Main Page";
            this.tabs.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlOutputControls.ResumeLayout(false);
            this.pnlOutput.ResumeLayout(false);
            this.tabHitCounter.ResumeLayout(false);
            this.pnlTimerCtrls.ResumeLayout(false);
            this.pnlHitCounterButtons.ResumeLayout(false);
            this.pnlHitCounterButtons.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.pnlControlButtons.ResumeLayout(false);
            this.pnlControlButtons.PerformLayout();
            this.tabGraph.ResumeLayout(false);
            this.tabsGraphView.ResumeLayout(false);
            this.tabGraphMain.ResumeLayout(false);
            this.pnlGraphMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtGraphMain)).EndInit();
            this.pnlGraphMainControls.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlGraphMainUnits.ResumeLayout(false);
            this.pnlGraphMainDate.ResumeLayout(false);
            this.pnlGraphMainButtons.ResumeLayout(false);
            this.tabGraphHitCounter.ResumeLayout(false);
            this.pnlGraphHitCounter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtGraphHitCounter)).EndInit();
            this.pnlGraphHitCounterControls.ResumeLayout(false);
            this.flGraphMainControls.ResumeLayout(false);
            this.pnlGraphHitCounterUnits.ResumeLayout(false);
            this.pnlGraphHitCounterDate.ResumeLayout(false);
            this.pnlGraphHitCounterSession.ResumeLayout(false);
            this.pnlGraphHitCounterButtons.ResumeLayout(false);
            this.tabGraphControl.ResumeLayout(false);
            this.pnlGraphControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtGraphControl)).EndInit();
            this.pnlGraphControlControls.ResumeLayout(false);
            this.flGraphControlControls.ResumeLayout(false);
            this.pnlGraphControlUnits.ResumeLayout(false);
            this.pnlGraphControlDate.ResumeLayout(false);
            this.pnlGraphControlSession.ResumeLayout(false);
            this.pnlGraphControlButtons.ResumeLayout(false);
            this.pnlClose.ResumeLayout(false);
            this.pnlClose.PerformLayout();
            this.tabStatistics.ResumeLayout(false);
            this.tabsStatistics.ResumeLayout(false);
            this.tabStatsMain.ResumeLayout(false);
            this.pnlStatsMainListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsMain)).EndInit();
            this.pnlStatsMainButtons.ResumeLayout(false);
            this.pnlStatsButtons.ResumeLayout(false);
            this.pnlStatsButtons.PerformLayout();
            this.tabStatsHitCounter.ResumeLayout(false);
            this.pnlStatsHitCounter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsHitCounter)).EndInit();
            this.pnlStatsHitCounterControls.ResumeLayout(false);
            this.pnlStatsHitCounterClose.ResumeLayout(false);
            this.pnlStatsHitCounterClose.PerformLayout();
            this.tabStatsControl.ResumeLayout(false);
            this.pnlStatsControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsControl)).EndInit();
            this.pnlStatsControlControls.ResumeLayout(false);
            this.pnlStatsControlClose.ResumeLayout(false);
            this.pnlStatsControlClose.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.pnlChoosePort.ResumeLayout(false);
            this.pnlDBCheck.ResumeLayout(false);
            this.pnlSettingsClose.ResumeLayout(false);
            this.pnlSettingsClose.PerformLayout();
            this.pnlMassInput.ResumeLayout(false);
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.pnlTheme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialTabControl tabs;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ImageList imgList;
        private MaterialSkin.Controls.MaterialButton btnStart;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialButton btnStop;
        private MaterialSkin.Controls.MaterialButton btnSettingsClose;
        private MaterialSkin.Controls.MaterialButton btnStatsClose;
        private MaterialSkin.Controls.MaterialLabel lblTheme;
        private MaterialSkin.Controls.MaterialButton btnDark;
        private MaterialSkin.Controls.MaterialButton btnLight;
        private System.Windows.Forms.Panel pnlTheme;
        private System.Windows.Forms.Panel pnlCheck;
        private MaterialSkin.Controls.MaterialButton btnCheck;
        private MaterialSkin.Controls.MaterialLabel lblCheck;
        private System.Windows.Forms.Panel pnlOutput;
        private System.Windows.Forms.Panel pnlOutputControls;
        private MaterialSkin.Controls.MaterialComboBox cmbUnit;
        private MaterialSkin.Controls.MaterialLabel lblUnit;
        private MaterialSkin.Controls.MaterialLabel lblOutput;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlMassInput;
        private MaterialSkin.Controls.MaterialButton btnChangeMass;
        private MaterialSkin.Controls.MaterialLabel lblMass;
        private MaterialSkin.Controls.MaterialTextBox2 txtMassInput;
        private System.Windows.Forms.TabPage tabHitCounter;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.Panel pnlHitCounterButtons;
        private MaterialSkin.Controls.MaterialButton btnHitCounterStart;
        private MaterialSkin.Controls.MaterialButton btnHitCounterClose;
        private System.Windows.Forms.Panel pnlControlButtons;
        private MaterialSkin.Controls.MaterialButton btnControlStart;
        private MaterialSkin.Controls.MaterialButton btnControlClose;
        private System.Windows.Forms.Panel pnlStatsButtons;
        private System.Windows.Forms.Panel pnlSettingsClose;
        private MaterialSkin.Controls.MaterialButton btnHitCounterStop;
        private MaterialSkin.Controls.MaterialButton btnControlStop;
        private MaterialSkin.Controls.MaterialTabControl tabsStatistics;
        private System.Windows.Forms.TabPage tabStatsMain;
        private System.Windows.Forms.TabPage tabStatsHitCounter;
        private System.Windows.Forms.TabPage tabStatsControl;
        private MaterialSkin.Controls.MaterialTabSelector tsStats;
        private System.Windows.Forms.Panel pnlTimerCtrls;
        private MaterialSkin.Controls.MaterialLabel lblHitTimer;
        private MaterialSkin.Controls.MaterialButton btnHitTimer;
        private MaterialSkin.Controls.MaterialTextBox2 txtHitTimer;
        private MaterialSkin.Controls.MaterialCheckbox cbHitTimer;
        private MaterialSkin.Controls.MaterialTextBox txtCurrentMass;
        private MaterialSkin.Controls.MaterialLabel lblCurrentMass;
        private MaterialSkin.Controls.MaterialTabControl tabsGraphView;
        private System.Windows.Forms.TabPage tabGraphMain;
        private System.Windows.Forms.TabPage tabGraphHitCounter;
        private System.Windows.Forms.TabPage tabGraphControl;
        private MaterialSkin.Controls.MaterialTabSelector tsGraphView;
        private System.Windows.Forms.Panel pnlGraphMainControls;
        private System.Windows.Forms.Panel pnlGraphMainButtons;
        private MaterialSkin.Controls.MaterialButton btnGraphMainClearGraph;
        private MaterialSkin.Controls.MaterialButton btnGraphMainGenerateGraph;
        private System.Windows.Forms.Panel pnlGraphMainDate;
        private MaterialSkin.Controls.MaterialLabel lblGraphMainSetDate;
        private System.Windows.Forms.DateTimePicker dtpGraphMainDate;
        private System.Windows.Forms.Panel pnlGraphMainUnits;
        private MaterialSkin.Controls.MaterialComboBox cmbGraphMainUnits;
        private MaterialSkin.Controls.MaterialLabel lblGraphMainChooseUnit;
        private System.Windows.Forms.Panel pnlGraphControlControls;
        private System.Windows.Forms.Panel pnlDBCheck;
        private MaterialSkin.Controls.MaterialButton btnDBCheck;
        private MaterialSkin.Controls.MaterialLabel lblDBCheck;
        private System.Windows.Forms.Panel pnlGraphMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtGraphMain;
        private System.Windows.Forms.Panel pnlGraphControl;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtGraphControl;
        private System.Windows.Forms.Panel pnlStatsHitCounterClose;
        private MaterialSkin.Controls.MaterialButton btnStatsHitCounterClose;
        private System.Windows.Forms.Panel pnlStatsControlClose;
        private MaterialSkin.Controls.MaterialButton btnStatsControlClose;
        private System.Windows.Forms.Panel pnlChoosePort;
        private MaterialSkin.Controls.MaterialButton btnOpenPort;
        private MaterialSkin.Controls.MaterialComboBox cmbPorts;
        private MaterialSkin.Controls.MaterialLabel lblChoosePort;
        private MaterialSkin.Controls.MaterialTextBox txtCurrentPort;
        private MaterialSkin.Controls.MaterialLabel lblCurrentPort;
        private System.Windows.Forms.Panel pnlStatsMainListView;
        private System.Windows.Forms.DataGridView dgvStatsMain;
        private System.Windows.Forms.Panel pnlStatsMainButtons;
        private MaterialSkin.Controls.MaterialButton btnStatsMainGenerate;
        private System.Windows.Forms.DateTimePicker dtpStatsMainDate;
        private MaterialSkin.Controls.MaterialLabel lblStatsMainDate;
        private MaterialSkin.Controls.MaterialButton btnStatsMainClear;
        private System.Windows.Forms.Panel pnlStatsHitCounter;
        private System.Windows.Forms.DataGridView dgvStatsHitCounter;
        private System.Windows.Forms.Panel pnlStatsHitCounterControls;
        private MaterialSkin.Controls.MaterialButton btnStatsHitCounterClear;
        private MaterialSkin.Controls.MaterialButton btnStatsHitCounterGenerate;
        private System.Windows.Forms.DateTimePicker dtpStatsHitCounterDate;
        private MaterialSkin.Controls.MaterialLabel lblStatsHitCounterDate;
        private System.Windows.Forms.Panel pnlStatsControl;
        private System.Windows.Forms.DataGridView dgvStatsControl;
        private System.Windows.Forms.Panel pnlStatsControlControls;
        private MaterialSkin.Controls.MaterialButton btnStatsControlClear;
        private MaterialSkin.Controls.MaterialButton btnStatsControlGenerate;
        private System.Windows.Forms.DateTimePicker dtpStatsControlDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlGraphHitCounterControls;
        private System.Windows.Forms.FlowLayoutPanel flGraphMainControls;
        private System.Windows.Forms.Panel pnlGraphHitCounterUnits;
        private MaterialSkin.Controls.MaterialComboBox cbGraphHitCounterUnits;
        private MaterialSkin.Controls.MaterialLabel lblGraphHitCounterChooseUnit;
        private System.Windows.Forms.Panel pnlGraphHitCounterDate;
        private MaterialSkin.Controls.MaterialLabel lblGraphHitCounterDate;
        private System.Windows.Forms.DateTimePicker dtpGraphHitCounterDate;
        private System.Windows.Forms.Panel pnlGraphHitCounterSession;
        private MaterialSkin.Controls.MaterialComboBox cmbGraphHitCounterSessions;
        private MaterialSkin.Controls.MaterialLabel lblGraphHitCounterSession;
        private System.Windows.Forms.Panel pnlGraphHitCounterButtons;
        private MaterialSkin.Controls.MaterialButton btnGraphHitCounterClearGraph;
        private MaterialSkin.Controls.MaterialButton btnGraphHitCounterGenerateGraph;
        private System.Windows.Forms.Panel pnlClose;
        private MaterialSkin.Controls.MaterialButton btnGraphClose;
        private System.Windows.Forms.Panel pnlGraphHitCounter;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtGraphHitCounter;
        private System.Windows.Forms.FlowLayoutPanel flGraphControlControls;
        private System.Windows.Forms.Panel pnlGraphControlUnits;
        private MaterialSkin.Controls.MaterialComboBox cmbGraphControlUnits;
        private MaterialSkin.Controls.MaterialLabel lblGraphControlUnits;
        private System.Windows.Forms.Panel pnlGraphControlDate;
        private MaterialSkin.Controls.MaterialLabel lblGraphCOntrolDate;
        private System.Windows.Forms.DateTimePicker dtpGraphControlDate;
        private System.Windows.Forms.Panel pnlGraphControlSession;
        private MaterialSkin.Controls.MaterialComboBox cmbGraphControlSessions;
        private MaterialSkin.Controls.MaterialLabel lblGraphControlSessions;
        private System.Windows.Forms.Panel pnlGraphControlButtons;
        private MaterialSkin.Controls.MaterialButton btnGraphControlClear;
        private MaterialSkin.Controls.MaterialButton btnGraphControlGenerate;
        private MaterialSkin.Controls.MaterialButton btnRefreshPorts;
    }
}

