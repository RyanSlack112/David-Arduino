namespace David_Arduino
{
    partial class Login
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
            this.tsLoginForm = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabsLogin = new MaterialSkin.Controls.MaterialTabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.pnlLoginControls = new System.Windows.Forms.Panel();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.txtLoginPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtLoginName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblLoginPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblLoginName = new MaterialSkin.Controls.MaterialLabel();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.pnlRegisterControls = new System.Windows.Forms.Panel();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.txtRegisterPassConfirm = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRegisterPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblRegisterPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtRegisterEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblRegisterEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtRegisterLastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRegisterFirstName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblRegisterName = new MaterialSkin.Controls.MaterialLabel();
            this.txtRegisterUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblRegisterUsername = new MaterialSkin.Controls.MaterialLabel();
            this.tabsLogin.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.pnlLoginControls.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.pnlRegisterControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsLoginForm
            // 
            this.tsLoginForm.BaseTabControl = this.tabsLogin;
            this.tsLoginForm.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tsLoginForm.Depth = 0;
            this.tsLoginForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsLoginForm.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tsLoginForm.Location = new System.Drawing.Point(3, 24);
            this.tsLoginForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsLoginForm.Name = "tsLoginForm";
            this.tsLoginForm.Size = new System.Drawing.Size(459, 44);
            this.tsLoginForm.TabIndex = 0;
            // 
            // tabsLogin
            // 
            this.tabsLogin.Controls.Add(this.tabLogin);
            this.tabsLogin.Controls.Add(this.tabRegister);
            this.tabsLogin.Depth = 0;
            this.tabsLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsLogin.Location = new System.Drawing.Point(3, 68);
            this.tabsLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabsLogin.Multiline = true;
            this.tabsLogin.Name = "tabsLogin";
            this.tabsLogin.SelectedIndex = 0;
            this.tabsLogin.Size = new System.Drawing.Size(459, 568);
            this.tabsLogin.TabIndex = 1;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.pnlLoginControls);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(451, 542);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // pnlLoginControls
            // 
            this.pnlLoginControls.Controls.Add(this.btnLogin);
            this.pnlLoginControls.Controls.Add(this.txtLoginPassword);
            this.pnlLoginControls.Controls.Add(this.txtLoginName);
            this.pnlLoginControls.Controls.Add(this.lblLoginPassword);
            this.pnlLoginControls.Controls.Add(this.lblLoginName);
            this.pnlLoginControls.Location = new System.Drawing.Point(25, 20);
            this.pnlLoginControls.Name = "pnlLoginControls";
            this.pnlLoginControls.Size = new System.Drawing.Size(405, 498);
            this.pnlLoginControls.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(121, 328);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(158, 36);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.AnimateReadOnly = false;
            this.txtLoginPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLoginPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLoginPassword.Depth = 0;
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoginPassword.HideSelection = true;
            this.txtLoginPassword.Hint = "Enter Password";
            this.txtLoginPassword.LeadingIcon = null;
            this.txtLoginPassword.Location = new System.Drawing.Point(22, 216);
            this.txtLoginPassword.MaxLength = 32767;
            this.txtLoginPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '●';
            this.txtLoginPassword.PrefixSuffixText = null;
            this.txtLoginPassword.ReadOnly = false;
            this.txtLoginPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLoginPassword.SelectedText = "";
            this.txtLoginPassword.SelectionLength = 0;
            this.txtLoginPassword.SelectionStart = 0;
            this.txtLoginPassword.ShortcutsEnabled = true;
            this.txtLoginPassword.Size = new System.Drawing.Size(369, 48);
            this.txtLoginPassword.TabIndex = 8;
            this.txtLoginPassword.TabStop = false;
            this.txtLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginPassword.TrailingIcon = null;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginName.AnimateReadOnly = false;
            this.txtLoginName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLoginName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLoginName.Depth = 0;
            this.txtLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoginName.HideSelection = true;
            this.txtLoginName.Hint = "Enter Username";
            this.txtLoginName.LeadingIcon = null;
            this.txtLoginName.Location = new System.Drawing.Point(19, 52);
            this.txtLoginName.MaxLength = 32767;
            this.txtLoginName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.PrefixSuffixText = null;
            this.txtLoginName.ReadOnly = false;
            this.txtLoginName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLoginName.SelectedText = "";
            this.txtLoginName.SelectionLength = 0;
            this.txtLoginName.SelectionStart = 0;
            this.txtLoginName.ShortcutsEnabled = true;
            this.txtLoginName.Size = new System.Drawing.Size(372, 48);
            this.txtLoginName.TabIndex = 7;
            this.txtLoginName.TabStop = false;
            this.txtLoginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginName.TrailingIcon = null;
            this.txtLoginName.UseSystemPasswordChar = false;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginPassword.Depth = 0;
            this.lblLoginPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoginPassword.Location = new System.Drawing.Point(19, 194);
            this.lblLoginPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(372, 19);
            this.lblLoginPassword.TabIndex = 6;
            this.lblLoginPassword.Text = "Password";
            this.lblLoginPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginName
            // 
            this.lblLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginName.Depth = 0;
            this.lblLoginName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoginName.Location = new System.Drawing.Point(19, 30);
            this.lblLoginName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(372, 19);
            this.lblLoginName.TabIndex = 5;
            this.lblLoginName.Text = "Username";
            this.lblLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.pnlRegisterControls);
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(451, 542);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // pnlRegisterControls
            // 
            this.pnlRegisterControls.Controls.Add(this.btnRegister);
            this.pnlRegisterControls.Controls.Add(this.txtRegisterPassConfirm);
            this.pnlRegisterControls.Controls.Add(this.txtRegisterPass);
            this.pnlRegisterControls.Controls.Add(this.lblRegisterPassword);
            this.pnlRegisterControls.Controls.Add(this.txtRegisterEmail);
            this.pnlRegisterControls.Controls.Add(this.lblRegisterEmail);
            this.pnlRegisterControls.Controls.Add(this.txtRegisterLastName);
            this.pnlRegisterControls.Controls.Add(this.txtRegisterFirstName);
            this.pnlRegisterControls.Controls.Add(this.lblRegisterName);
            this.pnlRegisterControls.Controls.Add(this.txtRegisterUsername);
            this.pnlRegisterControls.Controls.Add(this.lblRegisterUsername);
            this.pnlRegisterControls.Location = new System.Drawing.Point(24, 22);
            this.pnlRegisterControls.Name = "pnlRegisterControls";
            this.pnlRegisterControls.Size = new System.Drawing.Size(404, 496);
            this.pnlRegisterControls.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.AutoSize = false;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(127, 415);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(158, 36);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegisterPassConfirm
            // 
            this.txtRegisterPassConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegisterPassConfirm.AnimateReadOnly = false;
            this.txtRegisterPassConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterPassConfirm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterPassConfirm.Depth = 0;
            this.txtRegisterPassConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterPassConfirm.HideSelection = true;
            this.txtRegisterPassConfirm.Hint = "Confirm Password";
            this.txtRegisterPassConfirm.LeadingIcon = null;
            this.txtRegisterPassConfirm.Location = new System.Drawing.Point(213, 328);
            this.txtRegisterPassConfirm.MaxLength = 32767;
            this.txtRegisterPassConfirm.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterPassConfirm.Name = "txtRegisterPassConfirm";
            this.txtRegisterPassConfirm.PasswordChar = '●';
            this.txtRegisterPassConfirm.PrefixSuffixText = null;
            this.txtRegisterPassConfirm.ReadOnly = false;
            this.txtRegisterPassConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterPassConfirm.SelectedText = "";
            this.txtRegisterPassConfirm.SelectionLength = 0;
            this.txtRegisterPassConfirm.SelectionStart = 0;
            this.txtRegisterPassConfirm.ShortcutsEnabled = true;
            this.txtRegisterPassConfirm.Size = new System.Drawing.Size(174, 48);
            this.txtRegisterPassConfirm.TabIndex = 9;
            this.txtRegisterPassConfirm.TabStop = false;
            this.txtRegisterPassConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterPassConfirm.TrailingIcon = null;
            this.txtRegisterPassConfirm.UseSystemPasswordChar = true;
            // 
            // txtRegisterPass
            // 
            this.txtRegisterPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegisterPass.AnimateReadOnly = false;
            this.txtRegisterPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterPass.Depth = 0;
            this.txtRegisterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterPass.HideSelection = true;
            this.txtRegisterPass.Hint = "Password";
            this.txtRegisterPass.LeadingIcon = null;
            this.txtRegisterPass.Location = new System.Drawing.Point(33, 328);
            this.txtRegisterPass.MaxLength = 32767;
            this.txtRegisterPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterPass.Name = "txtRegisterPass";
            this.txtRegisterPass.PasswordChar = '●';
            this.txtRegisterPass.PrefixSuffixText = null;
            this.txtRegisterPass.ReadOnly = false;
            this.txtRegisterPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterPass.SelectedText = "";
            this.txtRegisterPass.SelectionLength = 0;
            this.txtRegisterPass.SelectionStart = 0;
            this.txtRegisterPass.ShortcutsEnabled = true;
            this.txtRegisterPass.Size = new System.Drawing.Size(174, 48);
            this.txtRegisterPass.TabIndex = 8;
            this.txtRegisterPass.TabStop = false;
            this.txtRegisterPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterPass.TrailingIcon = null;
            this.txtRegisterPass.UseSystemPasswordChar = true;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterPassword.Depth = 0;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRegisterPassword.Location = new System.Drawing.Point(33, 306);
            this.lblRegisterPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(354, 19);
            this.lblRegisterPassword.TabIndex = 7;
            this.lblRegisterPassword.Text = "Password";
            this.lblRegisterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.AnimateReadOnly = false;
            this.txtRegisterEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterEmail.Depth = 0;
            this.txtRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterEmail.HideSelection = true;
            this.txtRegisterEmail.Hint = "Email";
            this.txtRegisterEmail.LeadingIcon = null;
            this.txtRegisterEmail.Location = new System.Drawing.Point(30, 235);
            this.txtRegisterEmail.MaxLength = 32767;
            this.txtRegisterEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.PasswordChar = '\0';
            this.txtRegisterEmail.PrefixSuffixText = null;
            this.txtRegisterEmail.ReadOnly = false;
            this.txtRegisterEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterEmail.SelectedText = "";
            this.txtRegisterEmail.SelectionLength = 0;
            this.txtRegisterEmail.SelectionStart = 0;
            this.txtRegisterEmail.ShortcutsEnabled = true;
            this.txtRegisterEmail.Size = new System.Drawing.Size(356, 48);
            this.txtRegisterEmail.TabIndex = 6;
            this.txtRegisterEmail.TabStop = false;
            this.txtRegisterEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterEmail.TrailingIcon = null;
            this.txtRegisterEmail.UseSystemPasswordChar = false;
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterEmail.Depth = 0;
            this.lblRegisterEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRegisterEmail.Location = new System.Drawing.Point(30, 212);
            this.lblRegisterEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(356, 23);
            this.lblRegisterEmail.TabIndex = 5;
            this.lblRegisterEmail.Text = "Email";
            this.lblRegisterEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegisterLastName
            // 
            this.txtRegisterLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegisterLastName.AnimateReadOnly = false;
            this.txtRegisterLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterLastName.Depth = 0;
            this.txtRegisterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterLastName.HideSelection = true;
            this.txtRegisterLastName.Hint = "Last Name";
            this.txtRegisterLastName.LeadingIcon = null;
            this.txtRegisterLastName.Location = new System.Drawing.Point(210, 135);
            this.txtRegisterLastName.MaxLength = 32767;
            this.txtRegisterLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterLastName.Name = "txtRegisterLastName";
            this.txtRegisterLastName.PasswordChar = '\0';
            this.txtRegisterLastName.PrefixSuffixText = null;
            this.txtRegisterLastName.ReadOnly = false;
            this.txtRegisterLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterLastName.SelectedText = "";
            this.txtRegisterLastName.SelectionLength = 0;
            this.txtRegisterLastName.SelectionStart = 0;
            this.txtRegisterLastName.ShortcutsEnabled = true;
            this.txtRegisterLastName.Size = new System.Drawing.Size(176, 48);
            this.txtRegisterLastName.TabIndex = 4;
            this.txtRegisterLastName.TabStop = false;
            this.txtRegisterLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterLastName.TrailingIcon = null;
            this.txtRegisterLastName.UseSystemPasswordChar = false;
            // 
            // txtRegisterFirstName
            // 
            this.txtRegisterFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegisterFirstName.AnimateReadOnly = false;
            this.txtRegisterFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterFirstName.Depth = 0;
            this.txtRegisterFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterFirstName.HideSelection = true;
            this.txtRegisterFirstName.Hint = "First Name";
            this.txtRegisterFirstName.LeadingIcon = null;
            this.txtRegisterFirstName.Location = new System.Drawing.Point(30, 135);
            this.txtRegisterFirstName.MaxLength = 32767;
            this.txtRegisterFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterFirstName.Name = "txtRegisterFirstName";
            this.txtRegisterFirstName.PasswordChar = '\0';
            this.txtRegisterFirstName.PrefixSuffixText = null;
            this.txtRegisterFirstName.ReadOnly = false;
            this.txtRegisterFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterFirstName.SelectedText = "";
            this.txtRegisterFirstName.SelectionLength = 0;
            this.txtRegisterFirstName.SelectionStart = 0;
            this.txtRegisterFirstName.ShortcutsEnabled = true;
            this.txtRegisterFirstName.Size = new System.Drawing.Size(174, 48);
            this.txtRegisterFirstName.TabIndex = 3;
            this.txtRegisterFirstName.TabStop = false;
            this.txtRegisterFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterFirstName.TrailingIcon = null;
            this.txtRegisterFirstName.UseSystemPasswordChar = false;
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterName.Depth = 0;
            this.lblRegisterName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRegisterName.Location = new System.Drawing.Point(27, 113);
            this.lblRegisterName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(359, 19);
            this.lblRegisterName.TabIndex = 2;
            this.lblRegisterName.Text = "Name";
            this.lblRegisterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegisterUsername.AnimateReadOnly = false;
            this.txtRegisterUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegisterUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRegisterUsername.Depth = 0;
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegisterUsername.HideSelection = true;
            this.txtRegisterUsername.Hint = "Username";
            this.txtRegisterUsername.LeadingIcon = null;
            this.txtRegisterUsername.Location = new System.Drawing.Point(27, 34);
            this.txtRegisterUsername.MaxLength = 32767;
            this.txtRegisterUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.PasswordChar = '\0';
            this.txtRegisterUsername.PrefixSuffixText = null;
            this.txtRegisterUsername.ReadOnly = false;
            this.txtRegisterUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegisterUsername.SelectedText = "";
            this.txtRegisterUsername.SelectionLength = 0;
            this.txtRegisterUsername.SelectionStart = 0;
            this.txtRegisterUsername.ShortcutsEnabled = true;
            this.txtRegisterUsername.Size = new System.Drawing.Size(359, 48);
            this.txtRegisterUsername.TabIndex = 1;
            this.txtRegisterUsername.TabStop = false;
            this.txtRegisterUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterUsername.TrailingIcon = null;
            this.txtRegisterUsername.UseSystemPasswordChar = false;
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterUsername.Depth = 0;
            this.lblRegisterUsername.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRegisterUsername.Location = new System.Drawing.Point(27, 12);
            this.lblRegisterUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(359, 19);
            this.lblRegisterUsername.TabIndex = 0;
            this.lblRegisterUsername.Text = "Username";
            this.lblRegisterUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 639);
            this.Controls.Add(this.tabsLogin);
            this.Controls.Add(this.tsLoginForm);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "login";
            this.tabsLogin.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.pnlLoginControls.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.pnlRegisterControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tsLoginForm;
        private MaterialSkin.Controls.MaterialTabControl tabsLogin;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Panel pnlLoginControls;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialTextBox2 txtLoginPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtLoginName;
        private MaterialSkin.Controls.MaterialLabel lblLoginPassword;
        private MaterialSkin.Controls.MaterialLabel lblLoginName;
        private System.Windows.Forms.Panel pnlRegisterControls;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterLastName;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterFirstName;
        private MaterialSkin.Controls.MaterialLabel lblRegisterName;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterUsername;
        private MaterialSkin.Controls.MaterialLabel lblRegisterUsername;
        private MaterialSkin.Controls.MaterialLabel lblRegisterPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterEmail;
        private MaterialSkin.Controls.MaterialLabel lblRegisterEmail;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterPassConfirm;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegisterPass;
    }
}