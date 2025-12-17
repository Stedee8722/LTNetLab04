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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            btnCancel = new Button();
            label1 = new Label();
            linklbkRegister = new LinkLabel();
            LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginInfo
            // 
            LoginInfo.BackColor = Color.Transparent;
            LoginInfo.Controls.Add(linklbkRegister);
            LoginInfo.Controls.Add(label1);
            LoginInfo.Controls.Add(btnCancel);
            LoginInfo.Controls.Add(btnLogin);
            LoginInfo.Controls.Add(txtPassword);
            LoginInfo.Controls.Add(txtUsername);
            LoginInfo.Controls.Add(pictureBox1);
            LoginInfo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginInfo.Location = new Point(12, 3);
            LoginInfo.Name = "LoginInfo";
            LoginInfo.Size = new Size(774, 534);
            LoginInfo.TabIndex = 0;
            LoginInfo.TabStop = false;
            LoginInfo.Text = "Login Info";
            LoginInfo.Enter += groupBox1_Enter;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(247, 362);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(280, 39);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(247, 317);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(280, 39);
            txtUsername.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(247, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(247, 407);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 55);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "   &Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(394, 407);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 55);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "   &Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(211, 479);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 5;
            label1.Text = "Don't have an account? Register one";
            label1.Click += label1_Click_1;
            // 
            // linklbkRegister
            // 
            linklbkRegister.AutoSize = true;
            linklbkRegister.BackColor = Color.Transparent;
            linklbkRegister.Font = new Font("Segoe UI", 9F);
            linklbkRegister.Location = new Point(505, 479);
            linklbkRegister.Name = "linklbkRegister";
            linklbkRegister.Size = new Size(46, 25);
            linklbkRegister.TabIndex = 6;
            linklbkRegister.TabStop = true;
            linklbkRegister.Text = "here";
            linklbkRegister.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(798, 549);
            Controls.Add(LoginInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "LoginForm";
            LoginInfo.ResumeLayout(false);
            LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
