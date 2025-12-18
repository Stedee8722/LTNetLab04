namespace LTNetLab04
{
    partial class AirTicketBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirTicketBookingForm));
            lsbAirTicketList = new ListBox();
            label1 = new Label();
            btnAdd = new Button();
            label2 = new Label();
            rtxtRegistrationInfo = new RichTextBox();
            btnConfirm = new Button();
            btnLogout = new Button();
            pictureAvatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).BeginInit();
            SuspendLayout();
            // 
            // lsbAirTicketList
            // 
            lsbAirTicketList.FormattingEnabled = true;
            lsbAirTicketList.Location = new Point(34, 53);
            lsbAirTicketList.Name = "lsbAirTicketList";
            lsbAirTicketList.Size = new Size(192, 259);
            lsbAirTicketList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("8bitoperator JVE", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 13);
            label1.Name = "label1";
            label1.Size = new Size(137, 27);
            label1.TabIndex = 1;
            label1.Text = "Flight List";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(81, 320);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(6, 0, 0, 0);
            btnAdd.Size = new Size(100, 43);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "    &Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("8bitoperator JVE", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(406, 13);
            label2.Name = "label2";
            label2.Size = new Size(209, 27);
            label2.TabIndex = 24;
            label2.Text = "Registration List";
            // 
            // rtxtRegistrationInfo
            // 
            rtxtRegistrationInfo.Location = new Point(266, 53);
            rtxtRegistrationInfo.Name = "rtxtRegistrationInfo";
            rtxtRegistrationInfo.Size = new Size(475, 259);
            rtxtRegistrationInfo.TabIndex = 25;
            rtxtRegistrationInfo.Text = "";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Image = (Image)resources.GetObject("btnConfirm.Image");
            btnConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirm.Location = new Point(384, 320);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Padding = new Padding(6, 0, 0, 0);
            btnConfirm.Size = new Size(100, 43);
            btnConfirm.TabIndex = 26;
            btnConfirm.Text = "   &Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(532, 320);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(6, 0, 0, 0);
            btnLogout.Size = new Size(100, 43);
            btnLogout.TabIndex = 27;
            btnLogout.Text = "    &Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureAvatar
            // 
            pictureAvatar.Location = new Point(287, 82);
            pictureAvatar.Name = "pictureAvatar";
            pictureAvatar.Size = new Size(60, 60);
            pictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvatar.TabIndex = 28;
            pictureAvatar.TabStop = false;
            // 
            // AirTicketBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 372);
            Controls.Add(pictureAvatar);
            Controls.Add(btnLogout);
            Controls.Add(btnConfirm);
            Controls.Add(rtxtRegistrationInfo);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(lsbAirTicketList);
            Name = "AirTicketBookingForm";
            Text = "Ticket Booking";
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbAirTicketList;
        private Label label1;
        private Button btnAdd;
        private Label label2;
        private RichTextBox rtxtRegistrationInfo;
        private Button btnConfirm;
        private Button btnLogout;
        private PictureBox pictureAvatar;
    }
}