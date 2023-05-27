namespace informationSystem
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordShowButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.captchaPicture = new System.Windows.Forms.PictureBox();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.fullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 125);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(254, 31);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(12, 53);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(254, 31);
            this.loginBox.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(181, 306);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 36);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordShowButton
            // 
            this.passwordShowButton.Location = new System.Drawing.Point(312, 122);
            this.passwordShowButton.Name = "passwordShowButton";
            this.passwordShowButton.Size = new System.Drawing.Size(117, 36);
            this.passwordShowButton.TabIndex = 2;
            this.passwordShowButton.Text = "Показать пароль";
            this.passwordShowButton.UseVisualStyleBackColor = true;
            this.passwordShowButton.Click += new System.EventHandler(this.passwordShowButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(62, 24);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 96);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(72, 24);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Пароль";
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.captchaTextBox.Location = new System.Drawing.Point(106, 269);
            this.captchaTextBox.MaxLength = 6;
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(254, 31);
            this.captchaTextBox.TabIndex = 3;
            // 
            // captchaPicture
            // 
            this.captchaPicture.Image = global::informationSystem.Properties.Resources.captcha;
            this.captchaPicture.Location = new System.Drawing.Point(85, 173);
            this.captchaPicture.Name = "captchaPicture";
            this.captchaPicture.Size = new System.Drawing.Size(294, 90);
            this.captchaPicture.TabIndex = 7;
            this.captchaPicture.TabStop = false;
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::informationSystem.Properties.Resources.logo;
            this.logoPicture.Location = new System.Drawing.Point(-6, -39);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(493, 446);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 8;
            this.logoPicture.TabStop = false;
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Location = new System.Drawing.Point(331, 9);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(57, 24);
            this.fullName.TabIndex = 9;
            this.fullName.Text = "label1";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.captchaPicture);
            this.Controls.Add(this.captchaTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordShowButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.logoPicture);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captchaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button passwordShowButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox captchaTextBox;
        private System.Windows.Forms.PictureBox captchaPicture;
        private System.Windows.Forms.PictureBox logoPicture;
        public System.Windows.Forms.Label fullName;
    }
}