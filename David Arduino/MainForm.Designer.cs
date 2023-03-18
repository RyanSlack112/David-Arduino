namespace David_Arduino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.pnlOutputControls = new System.Windows.Forms.Panel();
            this.lblUnit = new MaterialSkin.Controls.MaterialLabel();
            this.cmbUnit = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.lblOutput = new MaterialSkin.Controls.MaterialLabel();
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnStop = new MaterialSkin.Controls.MaterialButton();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.btnStatsClose = new MaterialSkin.Controls.MaterialButton();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.btnCheck = new MaterialSkin.Controls.MaterialButton();
            this.lblCheck = new MaterialSkin.Controls.MaterialLabel();
            this.pnlTheme = new System.Windows.Forms.Panel();
            this.lblTheme = new MaterialSkin.Controls.MaterialLabel();
            this.btnDark = new MaterialSkin.Controls.MaterialButton();
            this.btnLight = new MaterialSkin.Controls.MaterialButton();
            this.btnSettingsClose = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGraphClose = new MaterialSkin.Controls.MaterialButton();
            this.pnlGraphControls = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.tabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pnlOutputControls.SuspendLayout();
            this.pnlOutput.SuspendLayout();
            this.tabGraph.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.pnlCheck.SuspendLayout();
            this.pnlTheme.SuspendLayout();
            this.pnlGraphControls.SuspendLayout();
            this.pnlButtons.SuspendLayout();
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
            this.tabs.Controls.Add(this.tabGraph);
            this.tabs.Controls.Add(this.tabStatistics);
            this.tabs.Controls.Add(this.tabSettings);
            this.tabs.Depth = 0;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.ImageList = this.imageList1;
            this.tabs.Location = new System.Drawing.Point(3, 64);
            this.tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1067, 575);
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
            this.tabMain.Size = new System.Drawing.Size(1059, 532);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // pnlOutputControls
            // 
            this.pnlOutputControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOutputControls.Controls.Add(this.lblUnit);
            this.pnlOutputControls.Controls.Add(this.cmbUnit);
            this.pnlOutputControls.Location = new System.Drawing.Point(853, 6);
            this.pnlOutputControls.Name = "pnlOutputControls";
            this.pnlOutputControls.Size = new System.Drawing.Size(185, 247);
            this.pnlOutputControls.TabIndex = 4;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Depth = 0;
            this.lblUnit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUnit.Location = new System.Drawing.Point(18, 15);
            this.lblUnit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(80, 19);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "Select Unit:";
            // 
            // cmbUnit
            // 
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
            this.pnlOutput.Size = new System.Drawing.Size(655, 408);
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
            this.lblOutput.Size = new System.Drawing.Size(655, 408);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "6000.56N";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStart.Depth = 0;
            this.btnStart.HighEmphasis = true;
            this.btnStart.Icon = null;
            this.btnStart.Location = new System.Drawing.Point(13, 10);
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(88, 10);
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
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStop.Depth = 0;
            this.btnStop.HighEmphasis = true;
            this.btnStop.Icon = null;
            this.btnStop.Location = new System.Drawing.Point(16, 10);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStop.Size = new System.Drawing.Size(64, 36);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStop.UseAccentColor = false;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.pnlGraphControls);
            this.tabGraph.ImageKey = "Graph.png";
            this.tabGraph.Location = new System.Drawing.Point(4, 39);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(1059, 532);
            this.tabGraph.TabIndex = 1;
            this.tabGraph.Text = "Graph View";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.btnStatsClose);
            this.tabStatistics.ImageKey = "Statistics.png";
            this.tabStatistics.Location = new System.Drawing.Point(4, 39);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(1059, 532);
            this.tabStatistics.TabIndex = 2;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // btnStatsClose
            // 
            this.btnStatsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatsClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatsClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStatsClose.Depth = 0;
            this.btnStatsClose.HighEmphasis = true;
            this.btnStatsClose.Icon = null;
            this.btnStatsClose.Location = new System.Drawing.Point(989, 490);
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
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.pnlCheck);
            this.tabSettings.Controls.Add(this.pnlTheme);
            this.tabSettings.Controls.Add(this.btnSettingsClose);
            this.tabSettings.ImageKey = "Settings.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1059, 532);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.btnCheck);
            this.pnlCheck.Controls.Add(this.lblCheck);
            this.pnlCheck.Location = new System.Drawing.Point(16, 229);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(200, 249);
            this.pnlCheck.TabIndex = 5;
            // 
            // btnCheck
            // 
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
            this.lblCheck.AutoSize = true;
            this.lblCheck.Depth = 0;
            this.lblCheck.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCheck.Location = new System.Drawing.Point(40, 14);
            this.lblCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(128, 19);
            this.lblCheck.TabIndex = 0;
            this.lblCheck.Text = "Check Connection";
            // 
            // pnlTheme
            // 
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
            this.lblTheme.AutoSize = true;
            this.lblTheme.Depth = 0;
            this.lblTheme.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTheme.Location = new System.Drawing.Point(51, 13);
            this.lblTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(108, 19);
            this.lblTheme.TabIndex = 3;
            this.lblTheme.Text = "Change Theme";
            // 
            // btnDark
            // 
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
            // btnSettingsClose
            // 
            this.btnSettingsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettingsClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSettingsClose.Depth = 0;
            this.btnSettingsClose.HighEmphasis = true;
            this.btnSettingsClose.Icon = null;
            this.btnSettingsClose.Location = new System.Drawing.Point(989, 490);
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Graph.png");
            this.imageList1.Images.SetKeyName(1, "home.png");
            this.imageList1.Images.SetKeyName(2, "Settings.png");
            this.imageList1.Images.SetKeyName(3, "Statistics.png");
            // 
            // btnGraphClose
            // 
            this.btnGraphClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraphClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraphClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGraphClose.Depth = 0;
            this.btnGraphClose.HighEmphasis = true;
            this.btnGraphClose.Icon = null;
            this.btnGraphClose.Location = new System.Drawing.Point(983, 484);
            this.btnGraphClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGraphClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGraphClose.Name = "btnGraphClose";
            this.btnGraphClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGraphClose.Size = new System.Drawing.Size(66, 36);
            this.btnGraphClose.TabIndex = 0;
            this.btnGraphClose.Text = "Close";
            this.btnGraphClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGraphClose.UseAccentColor = false;
            this.btnGraphClose.UseVisualStyleBackColor = true;
            this.btnGraphClose.Click += new System.EventHandler(this.btnGraphClose_Click);
            // 
            // pnlGraphControls
            // 
            this.pnlGraphControls.Controls.Add(this.btnGraphClose);
            this.pnlGraphControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraphControls.Location = new System.Drawing.Point(3, 3);
            this.pnlGraphControls.Name = "pnlGraphControls";
            this.pnlGraphControls.Size = new System.Drawing.Size(1053, 526);
            this.pnlGraphControls.TabIndex = 3;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnStart);
            this.pnlButtons.Controls.Add(this.btnStop);
            this.pnlButtons.Location = new System.Drawing.Point(898, 480);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(155, 46);
            this.pnlButtons.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 642);
            this.Controls.Add(this.tabs);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabs;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Text = "Main Page";
            this.tabs.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.pnlOutputControls.ResumeLayout(false);
            this.pnlOutputControls.PerformLayout();
            this.pnlOutput.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.pnlTheme.ResumeLayout(false);
            this.pnlTheme.PerformLayout();
            this.pnlGraphControls.ResumeLayout(false);
            this.pnlGraphControls.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
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
        private System.Windows.Forms.ImageList imageList1;
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
        private System.Windows.Forms.Panel pnlGraphControls;
        private MaterialSkin.Controls.MaterialButton btnGraphClose;
        private System.Windows.Forms.Panel pnlButtons;
    }
}

