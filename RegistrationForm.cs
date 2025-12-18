using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTNetLab04
{
    public partial class RegistrationForm : Form
    {
        string startupPath;
        string avatarPath;
        LoginForm ParentForm;
        bool passwordVisibilityToggle = true;
        bool confirmPasswordVisibilityToggle = true;
        public RegistrationForm()
        {
            InitializeComponent();
            startupPath = LoginForm.originalForm.startupPath;
            ParentForm = LoginForm.originalForm;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDlg.Title = "Choose Avatar";
            openFileDlg.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
            openFileDlg.InitialDirectory = startupPath;

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                avatarPath = openFileDlg.FileName;
                picAvatar.Image = Image.FromFile(avatarPath);

                startupPath = Path.GetDirectoryName(avatarPath);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnPasswordVisibility_Click(object sender, EventArgs e)
        {
            passwordVisibilityToggle = !passwordVisibilityToggle;
            txtPassword.UseSystemPasswordChar = passwordVisibilityToggle;
            btnPasswordVisibility.Image = passwordVisibilityToggle ? Properties.Resources.show : Properties.Resources.hide;
        }

        private void btnConfirmPasswordVisibility_Click(object sender, EventArgs e)
        {
            confirmPasswordVisibilityToggle = !confirmPasswordVisibilityToggle;
            txtConfirmPassword.UseSystemPasswordChar = confirmPasswordVisibilityToggle;
            btnConfirmPasswordVisibility.Image = confirmPasswordVisibilityToggle ? Properties.Resources.show : Properties.Resources.hide;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var images = new[]
            {
                Properties.Resources.Doraemon,
                Properties.Resources.Doremi,
                Properties.Resources.Dekhi,
                Properties.Resources.Nobita,
                Properties.Resources.Chaien,
                Properties.Resources.Xuka,
                Properties.Resources.Xeko,
            };
            picAvatar.Image = images[Random.Shared.Next(images.Length)];

        }

        private void rdMale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { rdMale.Checked = true; e.Handled = true; }
        }

        private void rdFemale_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { rdFemale.Checked = true; e.Handled = true; }
        }
        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register();
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            register();
        }

        private void register()
        {
            if (txtCustomerID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Customer ID can't be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerID.Focus();
                return;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name can't be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }
            if (!rdMale.Checked && !rdFemale.Checked)
            {
                MessageBox.Show("Pick a gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPassportNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Passport number can't be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassportNo.Focus();
                return;
            }
            if (txtNationality.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nationality can't be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNationality.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Email can't be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }
            if (txtUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Username can't be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text.Trim().Length < 8)
            {
                MessageBox.Show("Password too short!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }
            if (txtConfirmPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Confirm password can't be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfirmPassword.Focus();
                return;
            }
            if (!validateEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Invalid email!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }
            if (ParentForm.userList.Exists(x => (x.customerID == txtCustomerID.Text.Trim())))
            {
                MessageBox.Show("Customer ID already existed!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerID.Focus();
                return;
            }
            if (ParentForm.userList.Exists(x => (x.username == txtUsername.Text.Trim())))
            {
                MessageBox.Show("Username already existed!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                return;
            }
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                MessageBox.Show("Password does not match!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfirmPassword.Focus();
                return;
            }

            ParentForm.userList.Add(new User(txtUsername.Text.Trim(), User.hashPassword(txtPassword.Text.Trim()), txtCustomerID.Text.Trim()));
            ParentForm.customerList.Add(new Customer(
                txtCustomerID.Text.Trim(), txtName.Text.Trim(), picAvatar.Image,
                dtBirthday.Value, (rdMale.Checked == true) ? Sex.Male : Sex.Female,
                txtPassportNo.Text.Trim(), txtNationality.Text.Trim(), txtEmail.Text.Trim()
            ));

            MessageBox.Show("New User is created!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool validateEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            dtBirthday.Value = DateTime.Now;
            rdMale.Checked = false;
            rdFemale.Checked = false;
            txtPassportNo.Text = "";
            txtNationality.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

            var images = new[]
            {
                Properties.Resources.Doraemon,
                Properties.Resources.Doremi,
                Properties.Resources.Dekhi,
                Properties.Resources.Nobita,
                Properties.Resources.Chaien,
                Properties.Resources.Xuka,
                Properties.Resources.Xeko,
            };
            picAvatar.Image = images[Random.Shared.Next(images.Length)];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }
    }
}
