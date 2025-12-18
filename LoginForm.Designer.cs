namespace LTNetLab04
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginInfo = new GroupBox();
            btnPasswordVisibility = new PictureBox();
            linklbkRegister = new LinkLabel();
            btnCancel = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnPasswordVisibility).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // LoginInfo
            // 
            LoginInfo.BackColor = Color.Transparent;
            LoginInfo.Controls.Add(btnPasswordVisibility);
            LoginInfo.Controls.Add(linklbkRegister);
            LoginInfo.Controls.Add(btnCancel);
            LoginInfo.Controls.Add(btnLogin);
            LoginInfo.Controls.Add(txtPassword);
            LoginInfo.Controls.Add(txtUsername);
            LoginInfo.Controls.Add(pictureBox1);
            LoginInfo.Controls.Add(label1);
            LoginInfo.Controls.Add(pictureBox3);
            LoginInfo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginInfo.Location = new Point(8, 2);
            LoginInfo.Margin = new Padding(2);
            LoginInfo.Name = "LoginInfo";
            LoginInfo.Padding = new Padding(2);
            LoginInfo.Size = new Size(542, 320);
            LoginInfo.TabIndex = 0;
            LoginInfo.TabStop = false;
            LoginInfo.Text = "Login Info";
            // 
            // btnPasswordVisibility
            // 
            btnPasswordVisibility.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnPasswordVisibility.BackgroundImageLayout = ImageLayout.None;
            btnPasswordVisibility.Cursor = Cursors.Hand;
            btnPasswordVisibility.Image = Properties.Resources.show;
            btnPasswordVisibility.Location = new Point(374, 223);
            btnPasswordVisibility.Name = "btnPasswordVisibility";
            btnPasswordVisibility.Size = new Size(29, 29);
            btnPasswordVisibility.SizeMode = PictureBoxSizeMode.Zoom;
            btnPasswordVisibility.TabIndex = 28;
            btnPasswordVisibility.TabStop = false;
            btnPasswordVisibility.Click += btnPasswordVisibility_Click;
            // 
            // linklbkRegister
            // 
            linklbkRegister.AutoSize = true;
            linklbkRegister.BackColor = Color.Transparent;
            linklbkRegister.Font = new Font("Segoe UI", 9F);
            linklbkRegister.Location = new Point(355, 294);
            linklbkRegister.Margin = new Padding(2, 0, 2, 0);
            linklbkRegister.Name = "linklbkRegister";
            linklbkRegister.Size = new Size(30, 15);
            linklbkRegister.TabIndex = 6;
            linklbkRegister.TabStop = true;
            linklbkRegister.Text = "here";
            linklbkRegister.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(276, 259);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(6, 0, 0, 0);
            btnCancel.Size = new Size(93, 33);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "   &Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(173, 259);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(6, 0, 0, 0);
            btnLogin.Size = new Size(93, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "   &Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(173, 223);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(196, 29);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += input_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(173, 190);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(196, 29);
            txtUsername.TabIndex = 1;
            txtUsername.KeyDown += input_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, 22);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(160, 294);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 15);
            label1.TabIndex = 5;
            label1.Text = "Don't have an account? Register one";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 138);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(542, 197);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(559, 329);
            Controls.Add(LoginInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            LoginInfo.ResumeLayout(false);
            LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnPasswordVisibility).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LoginInfo;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
        private LinkLabel linklbkRegister;
        private Label label1;
        private PictureBox btnPasswordVisibility;
        private PictureBox pictureBox3;
    }
}
