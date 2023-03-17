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
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnStop = new MaterialSkin.Controls.MaterialButton();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.btnGraphClose = new MaterialSkin.Controls.MaterialButton();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.btnStatsClose = new MaterialSkin.Controls.MaterialButton();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.pnlTheme = new System.Windows.Forms.Panel();
            this.lblTheme = new MaterialSkin.Controls.MaterialLabel();
            this.btnDark = new MaterialSkin.Controls.MaterialButton();
            this.btnLight = new MaterialSkin.Controls.MaterialButton();
            this.btnSettingsClose = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheck = new MaterialSkin.Controls.MaterialLabel();
            this.btnCheck = new MaterialSkin.Controls.MaterialButton();
            this.tabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabGraph.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.pnlTheme.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tabMain.Controls.Add(this.btnStart);
            this.tabMain.Controls.Add(this.btnClose);
            this.tabMain.Controls.Add(this.btnStop);
            this.tabMain.ImageKey = "home.png";
            this.tabMain.Location = new System.Drawing.Point(4, 39);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1059, 532);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStart.Depth = 0;
            this.btnStart.HighEmphasis = true;
            this.btnStart.Icon = null;
            this.btnStart.Location = new System.Drawing.Point(911, 490);
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
            this.btnClose.Location = new System.Drawing.Point(989, 490);
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
            this.btnStop.Location = new System.Drawing.Point(914, 491);
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
            this.tabGraph.Controls.Add(this.btnGraphClose);
            this.tabGraph.ImageKey = "Graph.png";
            this.tabGraph.Location = new System.Drawing.Point(4, 39);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(1059, 532);
            this.tabGraph.TabIndex = 1;
            this.tabGraph.Text = "Graph View";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // btnGraphClose
            // 
            this.btnGraphClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraphClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraphClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGraphClose.Depth = 0;
            this.btnGraphClose.HighEmphasis = true;
            this.btnGraphClose.Icon = null;
            this.btnGraphClose.Location = new System.Drawing.Point(989, 490);
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
            this.tabSettings.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.lblCheck);
            this.panel1.Location = new System.Drawing.Point(16, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 249);
            this.panel1.TabIndex = 5;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 642);
            this.Controls.Add(this.tabs);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabs;
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.tabs.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabGraph.ResumeLayout(false);
            this.tabGraph.PerformLayout();
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.pnlTheme.ResumeLayout(false);
            this.pnlTheme.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btnGraphClose;
        private MaterialSkin.Controls.MaterialButton btnStatsClose;
        private MaterialSkin.Controls.MaterialLabel lblTheme;
        private MaterialSkin.Controls.MaterialButton btnDark;
        private MaterialSkin.Controls.MaterialButton btnLight;
        private System.Windows.Forms.Panel pnlTheme;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnCheck;
        private MaterialSkin.Controls.MaterialLabel lblCheck;
    }
}

