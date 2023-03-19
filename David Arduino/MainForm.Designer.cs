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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.btnStop = new MaterialSkin.Controls.MaterialButton();
            this.pnlOutputControls = new System.Windows.Forms.Panel();
            this.btnTestMass = new MaterialSkin.Controls.MaterialButton();
            this.btnTest = new MaterialSkin.Controls.MaterialButton();
            this.lblUnit = new MaterialSkin.Controls.MaterialLabel();
            this.cmbUnit = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.lblOutput = new MaterialSkin.Controls.MaterialLabel();
            this.tabHitCounter = new System.Windows.Forms.TabPage();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.dgvGraph = new System.Windows.Forms.DataGridView();
            this.pnlGraphControls = new System.Windows.Forms.Panel();
            this.pnlGraphButtons = new System.Windows.Forms.Panel();
            this.btnClearGraph = new MaterialSkin.Controls.MaterialButton();
            this.btnGenerateGraph = new MaterialSkin.Controls.MaterialButton();
            this.lblGraphControls = new MaterialSkin.Controls.MaterialLabel();
            this.pnlCMBUnit = new System.Windows.Forms.Panel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.lblChooseUnit = new MaterialSkin.Controls.MaterialLabel();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.btnGraphClose = new MaterialSkin.Controls.MaterialButton();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.btnStatsClose = new MaterialSkin.Controls.MaterialButton();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.pnlMassInput = new System.Windows.Forms.Panel();
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
            this.btnSettingsClose = new MaterialSkin.Controls.MaterialButton();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new System.Windows.Forms.TabPage();
            this.pnlHitCounterButtons = new System.Windows.Forms.Panel();
            this.btnHitCounterClose = new MaterialSkin.Controls.MaterialButton();
            this.btnHitCounterStart = new MaterialSkin.Controls.MaterialButton();
            this.pnlStatsButtons = new System.Windows.Forms.Panel();
            this.pnlControlButtons = new System.Windows.Forms.Panel();
            this.btnControlClose = new MaterialSkin.Controls.MaterialButton();
            this.pnlSettingsClose = new System.Windows.Forms.Panel();
            this.btnControlStart = new MaterialSkin.Controls.MaterialButton();
            this.btnControlStop = new MaterialSkin.Controls.MaterialButton();
            this.btnHitCounterStop = new MaterialSkin.Controls.MaterialButton();
            this.tabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlOutputControls.SuspendLayout();
            this.pnlOutput.SuspendLayout();
            this.tabHitCounter.SuspendLayout();
            this.tabGraph.SuspendLayout();
            this.pnlGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraph)).BeginInit();
            this.pnlGraphControls.SuspendLayout();
            this.pnlGraphButtons.SuspendLayout();
            this.pnlCMBUnit.SuspendLayout();
            this.pnlClose.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.pnlMassInput.SuspendLayout();
            this.pnlCheck.SuspendLayout();
            this.pnlTheme.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pnlHitCounterButtons.SuspendLayout();
            this.pnlStatsButtons.SuspendLayout();
            this.pnlControlButtons.SuspendLayout();
            this.pnlSettingsClose.SuspendLayout();
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
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnStart);
            this.pnlButtons.Controls.Add(this.btnStop);
            this.pnlButtons.Location = new System.Drawing.Point(901, 483);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(155, 46);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStop.Depth = 0;
            this.btnStop.HighEmphasis = true;
            this.btnStop.Icon = null;
            this.btnStop.Location = new System.Drawing.Point(13, 6);
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
            // pnlOutputControls
            // 
            this.pnlOutputControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOutputControls.Controls.Add(this.btnTestMass);
            this.pnlOutputControls.Controls.Add(this.btnTest);
            this.pnlOutputControls.Controls.Add(this.lblUnit);
            this.pnlOutputControls.Controls.Add(this.cmbUnit);
            this.pnlOutputControls.Location = new System.Drawing.Point(853, 6);
            this.pnlOutputControls.Name = "pnlOutputControls";
            this.pnlOutputControls.Size = new System.Drawing.Size(185, 247);
            this.pnlOutputControls.TabIndex = 4;
            // 
            // btnTestMass
            // 
            this.btnTestMass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTestMass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTestMass.Depth = 0;
            this.btnTestMass.HighEmphasis = true;
            this.btnTestMass.Icon = null;
            this.btnTestMass.Location = new System.Drawing.Point(11, 170);
            this.btnTestMass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTestMass.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestMass.Name = "btnTestMass";
            this.btnTestMass.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTestMass.Size = new System.Drawing.Size(100, 36);
            this.btnTestMass.TabIndex = 3;
            this.btnTestMass.Text = "Test Mass";
            this.btnTestMass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTestMass.UseAccentColor = false;
            this.btnTestMass.UseVisualStyleBackColor = true;
            this.btnTestMass.Click += new System.EventHandler(this.btnTestMass_Click);
            // 
            // btnTest
            // 
            this.btnTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTest.Depth = 0;
            this.btnTest.HighEmphasis = true;
            this.btnTest.Icon = null;
            this.btnTest.Location = new System.Drawing.Point(11, 124);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTest.Name = "btnTest";
            this.btnTest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTest.Size = new System.Drawing.Size(64, 36);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTest.UseAccentColor = false;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
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
            // tabHitCounter
            // 
            this.tabHitCounter.Controls.Add(this.pnlHitCounterButtons);
            this.tabHitCounter.ImageKey = "Hit Counter.png";
            this.tabHitCounter.Location = new System.Drawing.Point(4, 39);
            this.tabHitCounter.Name = "tabHitCounter";
            this.tabHitCounter.Size = new System.Drawing.Size(1059, 532);
            this.tabHitCounter.TabIndex = 4;
            this.tabHitCounter.Text = "Hit Counter";
            this.tabHitCounter.UseVisualStyleBackColor = true;
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.pnlGraph);
            this.tabGraph.Controls.Add(this.pnlGraphControls);
            this.tabGraph.Controls.Add(this.pnlClose);
            this.tabGraph.ImageKey = "Graph.png";
            this.tabGraph.Location = new System.Drawing.Point(4, 39);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(1059, 532);
            this.tabGraph.TabIndex = 1;
            this.tabGraph.Text = "Graph View";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // pnlGraph
            // 
            this.pnlGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraph.Controls.Add(this.dgvGraph);
            this.pnlGraph.Location = new System.Drawing.Point(129, 7);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(685, 467);
            this.pnlGraph.TabIndex = 4;
            // 
            // dgvGraph
            // 
            this.dgvGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGraph.Location = new System.Drawing.Point(0, 0);
            this.dgvGraph.Name = "dgvGraph";
            this.dgvGraph.Size = new System.Drawing.Size(685, 467);
            this.dgvGraph.TabIndex = 0;
            // 
            // pnlGraphControls
            // 
            this.pnlGraphControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphControls.Controls.Add(this.pnlGraphButtons);
            this.pnlGraphControls.Controls.Add(this.pnlCMBUnit);
            this.pnlGraphControls.Location = new System.Drawing.Point(842, 6);
            this.pnlGraphControls.Name = "pnlGraphControls";
            this.pnlGraphControls.Size = new System.Drawing.Size(210, 468);
            this.pnlGraphControls.TabIndex = 3;
            // 
            // pnlGraphButtons
            // 
            this.pnlGraphButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraphButtons.Controls.Add(this.btnClearGraph);
            this.pnlGraphButtons.Controls.Add(this.btnGenerateGraph);
            this.pnlGraphButtons.Controls.Add(this.lblGraphControls);
            this.pnlGraphButtons.Location = new System.Drawing.Point(4, 145);
            this.pnlGraphButtons.Name = "pnlGraphButtons";
            this.pnlGraphButtons.Size = new System.Drawing.Size(203, 151);
            this.pnlGraphButtons.TabIndex = 3;
            // 
            // btnClearGraph
            // 
            this.btnClearGraph.AutoSize = false;
            this.btnClearGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearGraph.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearGraph.Depth = 0;
            this.btnClearGraph.HighEmphasis = true;
            this.btnClearGraph.Icon = null;
            this.btnClearGraph.Location = new System.Drawing.Point(26, 84);
            this.btnClearGraph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearGraph.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearGraph.Name = "btnClearGraph";
            this.btnClearGraph.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearGraph.Size = new System.Drawing.Size(148, 36);
            this.btnClearGraph.TabIndex = 2;
            this.btnClearGraph.Text = "Clear Graph";
            this.btnClearGraph.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearGraph.UseAccentColor = false;
            this.btnClearGraph.UseVisualStyleBackColor = true;
            // 
            // btnGenerateGraph
            // 
            this.btnGenerateGraph.AutoSize = false;
            this.btnGenerateGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerateGraph.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerateGraph.Depth = 0;
            this.btnGenerateGraph.HighEmphasis = true;
            this.btnGenerateGraph.Icon = null;
            this.btnGenerateGraph.Location = new System.Drawing.Point(26, 36);
            this.btnGenerateGraph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerateGraph.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerateGraph.Name = "btnGenerateGraph";
            this.btnGenerateGraph.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerateGraph.Size = new System.Drawing.Size(148, 36);
            this.btnGenerateGraph.TabIndex = 1;
            this.btnGenerateGraph.Text = "Generate Graph";
            this.btnGenerateGraph.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerateGraph.UseAccentColor = false;
            this.btnGenerateGraph.UseVisualStyleBackColor = true;
            // 
            // lblGraphControls
            // 
            this.lblGraphControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGraphControls.Depth = 0;
            this.lblGraphControls.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGraphControls.Location = new System.Drawing.Point(26, 11);
            this.lblGraphControls.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGraphControls.Name = "lblGraphControls";
            this.lblGraphControls.Size = new System.Drawing.Size(154, 19);
            this.lblGraphControls.TabIndex = 0;
            this.lblGraphControls.Text = "Graph Controls";
            this.lblGraphControls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCMBUnit
            // 
            this.pnlCMBUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCMBUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCMBUnit.Controls.Add(this.materialComboBox1);
            this.pnlCMBUnit.Controls.Add(this.lblChooseUnit);
            this.pnlCMBUnit.Location = new System.Drawing.Point(4, 13);
            this.pnlCMBUnit.Name = "pnlCMBUnit";
            this.pnlCMBUnit.Size = new System.Drawing.Size(203, 125);
            this.pnlCMBUnit.TabIndex = 2;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Force",
            "Acceleration"});
            this.materialComboBox1.Location = new System.Drawing.Point(24, 42);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(158, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 1;
            // 
            // lblChooseUnit
            // 
            this.lblChooseUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChooseUnit.Depth = 0;
            this.lblChooseUnit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblChooseUnit.Location = new System.Drawing.Point(24, 20);
            this.lblChooseUnit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChooseUnit.Name = "lblChooseUnit";
            this.lblChooseUnit.Size = new System.Drawing.Size(158, 19);
            this.lblChooseUnit.TabIndex = 0;
            this.lblChooseUnit.Text = "Choose Unit:";
            this.lblChooseUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlClose
            // 
            this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClose.Controls.Add(this.btnGraphClose);
            this.pnlClose.Location = new System.Drawing.Point(898, 480);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(158, 49);
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
            this.btnGraphClose.Location = new System.Drawing.Point(88, 10);
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
            this.tabStatistics.Controls.Add(this.pnlStatsButtons);
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
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.pnlSettingsClose);
            this.tabSettings.Controls.Add(this.pnlMassInput);
            this.tabSettings.Controls.Add(this.pnlCheck);
            this.tabSettings.Controls.Add(this.pnlTheme);
            this.tabSettings.ImageKey = "Settings.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1059, 532);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // pnlMassInput
            // 
            this.pnlMassInput.Controls.Add(this.btnChangeMass);
            this.pnlMassInput.Controls.Add(this.lblMass);
            this.pnlMassInput.Controls.Add(this.txtMassInput);
            this.pnlMassInput.Location = new System.Drawing.Point(244, 15);
            this.pnlMassInput.Name = "pnlMassInput";
            this.pnlMassInput.Size = new System.Drawing.Size(200, 151);
            this.pnlMassInput.TabIndex = 6;
            // 
            // btnChangeMass
            // 
            this.btnChangeMass.AutoSize = false;
            this.btnChangeMass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeMass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangeMass.Depth = 0;
            this.btnChangeMass.HighEmphasis = true;
            this.btnChangeMass.Icon = null;
            this.btnChangeMass.Location = new System.Drawing.Point(17, 95);
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
            this.lblMass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMass.Depth = 0;
            this.lblMass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMass.Location = new System.Drawing.Point(17, 13);
            this.lblMass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(167, 19);
            this.lblMass.TabIndex = 1;
            this.lblMass.Text = "Change Mass";
            this.lblMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMassInput
            // 
            this.txtMassInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMassInput.AnimateReadOnly = false;
            this.txtMassInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMassInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMassInput.Depth = 0;
            this.txtMassInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMassInput.HideSelection = true;
            this.txtMassInput.Hint = "Input Mass Here";
            this.txtMassInput.LeadingIcon = null;
            this.txtMassInput.Location = new System.Drawing.Point(17, 38);
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
            this.txtMassInput.Size = new System.Drawing.Size(167, 48);
            this.txtMassInput.TabIndex = 0;
            this.txtMassInput.TabStop = false;
            this.txtMassInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMassInput.TrailingIcon = null;
            this.txtMassInput.UseSystemPasswordChar = false;
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
            this.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblTheme.Depth = 0;
            this.lblTheme.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTheme.Location = new System.Drawing.Point(39, 13);
            this.lblTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(129, 19);
            this.lblTheme.TabIndex = 3;
            this.lblTheme.Text = "Change Theme";
            this.lblTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pnlControlButtons);
            this.tabControl.ImageKey = "Control.png";
            this.tabControl.Location = new System.Drawing.Point(4, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1059, 532);
            this.tabControl.TabIndex = 5;
            this.tabControl.Text = "Control";
            this.tabControl.UseVisualStyleBackColor = true;
            // 
            // pnlHitCounterButtons
            // 
            this.pnlHitCounterButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHitCounterButtons.Controls.Add(this.btnHitCounterClose);
            this.pnlHitCounterButtons.Controls.Add(this.btnHitCounterStart);
            this.pnlHitCounterButtons.Controls.Add(this.btnHitCounterStop);
            this.pnlHitCounterButtons.Location = new System.Drawing.Point(884, 474);
            this.pnlHitCounterButtons.Name = "pnlHitCounterButtons";
            this.pnlHitCounterButtons.Size = new System.Drawing.Size(172, 55);
            this.pnlHitCounterButtons.TabIndex = 0;
            // 
            // btnHitCounterClose
            // 
            this.btnHitCounterClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHitCounterClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHitCounterClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHitCounterClose.Depth = 0;
            this.btnHitCounterClose.HighEmphasis = true;
            this.btnHitCounterClose.Icon = null;
            this.btnHitCounterClose.Location = new System.Drawing.Point(102, 16);
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
            this.btnHitCounterStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHitCounterStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHitCounterStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHitCounterStart.Depth = 0;
            this.btnHitCounterStart.HighEmphasis = true;
            this.btnHitCounterStart.Icon = null;
            this.btnHitCounterStart.Location = new System.Drawing.Point(27, 16);
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
            // pnlStatsButtons
            // 
            this.pnlStatsButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsButtons.Controls.Add(this.btnStatsClose);
            this.pnlStatsButtons.Location = new System.Drawing.Point(968, 478);
            this.pnlStatsButtons.Name = "pnlStatsButtons";
            this.pnlStatsButtons.Size = new System.Drawing.Size(88, 51);
            this.pnlStatsButtons.TabIndex = 1;
            // 
            // pnlControlButtons
            // 
            this.pnlControlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlButtons.Controls.Add(this.btnControlClose);
            this.pnlControlButtons.Controls.Add(this.btnControlStart);
            this.pnlControlButtons.Controls.Add(this.btnControlStop);
            this.pnlControlButtons.Location = new System.Drawing.Point(882, 481);
            this.pnlControlButtons.Name = "pnlControlButtons";
            this.pnlControlButtons.Size = new System.Drawing.Size(174, 48);
            this.pnlControlButtons.TabIndex = 0;
            // 
            // btnControlClose
            // 
            this.btnControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // pnlSettingsClose
            // 
            this.pnlSettingsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettingsClose.Controls.Add(this.btnSettingsClose);
            this.pnlSettingsClose.Location = new System.Drawing.Point(970, 478);
            this.pnlSettingsClose.Name = "pnlSettingsClose";
            this.pnlSettingsClose.Size = new System.Drawing.Size(86, 51);
            this.pnlSettingsClose.TabIndex = 7;
            // 
            // btnControlStart
            // 
            this.btnControlStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // btnHitCounterStop
            // 
            this.btnHitCounterStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHitCounterStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHitCounterStop.Depth = 0;
            this.btnHitCounterStop.HighEmphasis = true;
            this.btnHitCounterStop.Icon = null;
            this.btnHitCounterStop.Location = new System.Drawing.Point(30, 16);
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
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlOutputControls.ResumeLayout(false);
            this.pnlOutputControls.PerformLayout();
            this.pnlOutput.ResumeLayout(false);
            this.tabHitCounter.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.pnlGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraph)).EndInit();
            this.pnlGraphControls.ResumeLayout(false);
            this.pnlGraphButtons.ResumeLayout(false);
            this.pnlCMBUnit.ResumeLayout(false);
            this.pnlClose.ResumeLayout(false);
            this.pnlClose.PerformLayout();
            this.tabStatistics.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.pnlMassInput.ResumeLayout(false);
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.pnlTheme.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.pnlHitCounterButtons.ResumeLayout(false);
            this.pnlHitCounterButtons.PerformLayout();
            this.pnlStatsButtons.ResumeLayout(false);
            this.pnlStatsButtons.PerformLayout();
            this.pnlControlButtons.ResumeLayout(false);
            this.pnlControlButtons.PerformLayout();
            this.pnlSettingsClose.ResumeLayout(false);
            this.pnlSettingsClose.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btnTest;
        private System.Windows.Forms.Panel pnlGraphControls;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel lblChooseUnit;
        private System.Windows.Forms.Panel pnlClose;
        private MaterialSkin.Controls.MaterialButton btnGraphClose;
        private System.Windows.Forms.Panel pnlCMBUnit;
        private System.Windows.Forms.Panel pnlGraphButtons;
        private MaterialSkin.Controls.MaterialButton btnClearGraph;
        private MaterialSkin.Controls.MaterialButton btnGenerateGraph;
        private MaterialSkin.Controls.MaterialLabel lblGraphControls;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.DataGridView dgvGraph;
        private System.Windows.Forms.Panel pnlMassInput;
        private MaterialSkin.Controls.MaterialButton btnChangeMass;
        private MaterialSkin.Controls.MaterialLabel lblMass;
        private MaterialSkin.Controls.MaterialTextBox2 txtMassInput;
        private MaterialSkin.Controls.MaterialButton btnTestMass;
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
    }
}

