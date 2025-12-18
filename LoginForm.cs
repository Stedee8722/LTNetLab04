namespace LTNetLab04
{
    public partial class LoginForm : Form
    {
        public static LoginForm originalForm;
        public List<Customer> customerList;
        public List<User> userList;
        public List<Flight> flightList;
        public List<FlightRegistration> flightRegistrationList;
        public string startupPath;
        bool passwordVisibilityToggle = true;
        public LoginForm()
        {
            InitializeComponent();

            originalForm = this;
            startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            customerList = new List<Customer>();
            customerList.Add(new Customer("CS001", "Admin", Properties.Resources.Aym, new DateTime(2005, 8, 13), Sex.Male, "012345678910", "Vietnam", "admin@gmail.com"));

            userList = new List<User>();
            userList.Add(new User("Admin", User.hashPassword("password"), "CS001"));

            flightList = new List<Flight>();
            flightList.Add(new Flight("FL001", new DateTime(2025, 12, 14, 22, 30, 0), new DateTime(2025, 12, 15, 1, 0, 0), "Vietnam Airline"));
            flightList.Add(new Flight("FL002", new DateTime(2025, 12, 14, 23, 15, 0), new DateTime(2025, 12, 15, 2, 5, 0), "Vietnam Airline"));
            flightList.Add(new Flight("FL003", new DateTime(2025, 12, 15, 0, 45, 0), new DateTime(2025, 12, 15, 3, 30, 0), "VietJet Air"));
            flightList.Add(new Flight("FL004", new DateTime(2025, 12, 15, 6, 0, 0), new DateTime(2025, 12, 15, 8, 20, 0), "Bamboo Airways"));
            flightList.Add(new Flight("FL005", new DateTime(2025, 12, 15, 9, 30, 0), new DateTime(2025, 12, 15, 11, 45, 0), "Vietnam Airline"));
            flightList.Add(new Flight("FL006", new DateTime(2025, 12, 15, 13, 15, 0), new DateTime(2025, 12, 15, 15, 40, 0), "VietJet Air"));
            flightList.Add(new Flight("FL007", new DateTime(2025, 12, 15, 16, 50, 0), new DateTime(2025, 12, 15, 19, 10, 0), "Bamboo Airways"));
            flightList.Add(new Flight("FL008", new DateTime(2025, 12, 15, 18, 30, 0), new DateTime(2025, 12, 15, 21, 0, 0), "Vietnam Airline"));
            flightList.Add(new Flight("FL009", new DateTime(2025, 12, 15, 20, 45, 0), new DateTime(2025, 12, 15, 23, 25, 0), "VietJet Air"));
            flightList.Add(new Flight("FL010", new DateTime(2025, 12, 16, 6, 15, 0), new DateTime(2025, 12, 16, 8, 35, 0), "Bamboo Airways"));
            flightList.Add(new Flight("FL011", new DateTime(2025, 12, 16, 10, 0, 0), new DateTime(2025, 12, 16, 12, 20, 0), "Vietnam Airline"));

            flightRegistrationList = new List<FlightRegistration>();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            registrationForm.Show();
        }

        private void btnPasswordVisibility_Click(object sender, EventArgs e)
        {
            passwordVisibilityToggle = !passwordVisibilityToggle;
            txtPassword.UseSystemPasswordChar = passwordVisibilityToggle;
            btnPasswordVisibility.Image = passwordVisibilityToggle ? Properties.Resources.show : Properties.Resources.hide;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
                e.Handled = true;
            }
        }

        private void login()
        {
            if (txtUsername.Text.Length <= 0)
            {
                MessageBox.Show("Please enter username!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text.Length <= 0)
            {
                MessageBox.Show("Please enter password!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }
            User user = userList.Find(x => (x.username == txtUsername.Text));
            if (user == null)
            {
                MessageBox.Show("User has not register an account!", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                return;
            }
            else
            {
                if (!User.verifyPassword(txtPassword.Text, user.password))
                {
                    user = null;
                    MessageBox.Show("Wrong password!", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
            }

            AirTicketBookingForm form = new AirTicketBookingForm();
            form.setCurrentUser(user);
            this.Hide();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        public void reset()
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
            txtUsername.Focus();
        }
    }
}
