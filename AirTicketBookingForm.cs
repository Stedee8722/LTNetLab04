using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTNetLab04
{
    public partial class AirTicketBookingForm : Form
    {
        public User currentUser;
        public Customer currentCustomer;
        string strRegistration;
        public int idxRegistration;
        LoginForm parentForm;
        public AirTicketBookingForm()
        {
            InitializeComponent();
            parentForm = LoginForm.originalForm;

            foreach (Flight flight in parentForm.flightList)
                lsbAirTicketList.Items.Add(flight.flightID);

            rtxtRegistrationInfo.Text = "";
        }

        public void setCurrentUser(User user)
        {
            currentUser = user;
            currentCustomer = parentForm.customerList.Find(x => (x.customerID == currentUser.customerID));
            pictureAvatar.Image = currentCustomer.avatar;

            idxRegistration = parentForm.flightRegistrationList.FindIndex(x => (x.customerID == currentCustomer.customerID));
            if (idxRegistration >= 0)
            {
                foreach (Flight flight in parentForm.flightRegistrationList[idxRegistration].flightBookedList)
                {
                    int idx = lsbAirTicketList.FindString(flight.flightID);
                    lsbAirTicketList.SetSelected(idx, true);
                }
            }

            ShowRegistrationInfo();
        }

        public string ShowRegistrationInfo()
        {
            strRegistration = "\t\t\t Flight Booking for Customer \n";
            strRegistration += "_______________________________________________________________________________________________\n";
            strRegistration += String.Format("\t\tCustomer ID: {0}\n\t\tCustomer Name: {1}\n\n\n", currentCustomer.customerID, currentCustomer.customerName);

            strRegistration += "Flight ID\t\tDeparture Time\t\tArrival Time\t\tFlight Type";
            Flight flight;
            foreach (Object selectedItem in lsbAirTicketList.SelectedItems)
            {
                flight = parentForm.flightList.Find(x => (x.flightID == selectedItem.ToString()));

                if (flight != null)
                    strRegistration += "\n" + flight.flightID + "\t" + flight.timeDepart.ToString() + "\t" +
                        flight.timeArrival.ToString() + "\t" + flight.flightType;
            }

            idxRegistration = parentForm.flightRegistrationList.FindIndex(x => (x.customerID == currentCustomer.customerID));
            if (idxRegistration >= 0)
            {
                Flight bookedFlight = parentForm.flightRegistrationList[idxRegistration].flightBookedList[0];

                strRegistration += "\n_______________________________________________________________________________________________\n";
                strRegistration += "\t\t\t Booked flight\n";
                strRegistration += "Flight ID\t\tDeparture Time\t\tArrival Time\t\tFlight Type";
                strRegistration += "\n" + bookedFlight.flightID + "\t" + bookedFlight.timeDepart.ToString() + "\t" +
                            bookedFlight.timeArrival.ToString() + "\t" + bookedFlight.flightType;
            }
            
            rtxtRegistrationInfo.Text = strRegistration;

            return strRegistration;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
            parentForm.reset();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowRegistrationInfo(), "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idxRegistration < 0)
            {
                parentForm.flightRegistrationList.Add(new FlightRegistration(currentCustomer.customerID));
                idxRegistration = parentForm.flightRegistrationList.FindIndex(x => (x.customerID == currentCustomer.customerID));

                Flight flight;
                foreach (Object selectedItem in lsbAirTicketList.SelectedItems)
                {
                    flight = parentForm.flightList.Find(x => (x.flightID.ToString() == selectedItem.ToString()));
                    parentForm.flightRegistrationList[idxRegistration].flightBookedList.Add(flight);
                }
            }

            ShowRegistrationInfo();
        }
    }
}
