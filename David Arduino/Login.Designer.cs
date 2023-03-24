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
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.txtLoginPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtLoginName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblLoginPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblLoginName = new MaterialSkin.Controls.MaterialLabel();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.tabsLogin.SuspendLayout();
            this.tabLogin.SuspendLayout();
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
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.txtLoginPassword);
            this.tabLogin.Controls.Add(this.txtLoginName);
            this.tabLogin.Controls.Add(this.lblLoginPassword);
            this.tabLogin.Controls.Add(this.lblLoginName);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(451, 542);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
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
            this.btnLogin.Location = new System.Drawing.Point(148, 353);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(158, 36);
            this.btnLogin.TabIndex = 4;
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
            this.txtLoginPassword.Location = new System.Drawing.Point(99, 241);
            this.txtLoginPassword.MaxLength = 32767;
            this.txtLoginPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '\0';
            this.txtLoginPassword.PrefixSuffixText = null;
            this.txtLoginPassword.ReadOnly = false;
            this.txtLoginPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLoginPassword.SelectedText = "";
            this.txtLoginPassword.SelectionLength = 0;
            this.txtLoginPassword.SelectionStart = 0;
            this.txtLoginPassword.ShortcutsEnabled = true;
            this.txtLoginPassword.Size = new System.Drawing.Size(250, 48);
            this.txtLoginPassword.TabIndex = 3;
            this.txtLoginPassword.TabStop = false;
            this.txtLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginPassword.TrailingIcon = null;
            this.txtLoginPassword.UseSystemPasswordChar = false;
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
            this.txtLoginName.Hint = "Enter Username or Email";
            this.txtLoginName.LeadingIcon = null;
            this.txtLoginName.Location = new System.Drawing.Point(99, 91);
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
            this.txtLoginName.Size = new System.Drawing.Size(250, 48);
            this.txtLoginName.TabIndex = 2;
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
            this.lblLoginPassword.Location = new System.Drawing.Point(99, 201);
            this.lblLoginPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(250, 19);
            this.lblLoginPassword.TabIndex = 1;
            this.lblLoginPassword.Text = "Password";
            this.lblLoginPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginName
            // 
            this.lblLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginName.Depth = 0;
            this.lblLoginName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoginName.Location = new System.Drawing.Point(99, 55);
            this.lblLoginName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(250, 19);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "Username or Email ";
            this.lblLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabRegister
            // 
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(451, 542);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tsLoginForm;
        private MaterialSkin.Controls.MaterialTabControl tabsLogin;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialTextBox2 txtLoginPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtLoginName;
        private MaterialSkin.Controls.MaterialLabel lblLoginPassword;
        private MaterialSkin.Controls.MaterialLabel lblLoginName;
    }
}