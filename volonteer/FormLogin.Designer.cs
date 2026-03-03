namespace volonteer
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbLogo = new PictureBox();
            pnMain = new Panel();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            btnGuest = new Button();
            btnLogin = new Button();
            lblPassword = new Label();
            lblLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(142, 13);
            pbLogo.Margin = new Padding(4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(txtPassword);
            pnMain.Controls.Add(txtLogin);
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(lblPassword);
            pnMain.Controls.Add(lblLogin);
            pnMain.Location = new Point(28, 121);
            pnMain.Margin = new Padding(4);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(329, 232);
            pnMain.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(31, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(266, 26);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(31, 41);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(266, 26);
            txtLogin.TabIndex = 4;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(76, 175, 80);
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.ForeColor = Color.White;
            btnGuest.Location = new Point(97, 189);
            btnGuest.Margin = new Padding(4);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(134, 37);
            btnGuest.TabIndex = 3;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BtnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(76, 175, 80);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(97, 142);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 37);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(135, 77);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(58, 19);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(138, 12);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(52, 19);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(pnMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnMain;
        private TextBox txtPassword;
        private TextBox txtLogin;
        private Button btnGuest;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblLogin;
    }
}
