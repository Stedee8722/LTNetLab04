using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LTNetLab04
{
    public enum Sex { Male, Female };
    public class Customer
    {
        public string customerID {  get; set; }
        public string customerName { get; set; }
        private DateTime birthday { get; set; }
        private Sex gender {  get; set; }
        private string passportNumber { get; set; }
        private string nationality {  get; set; }
        private string email { get; set; }
        public Image avatar { get; set; }

        public Customer()
        {
            this.customerID = "NA";
        }

        public Customer(string customerID, string customerName, Image avatar, DateTime birthday, Sex gender, string passportNumber, string nationality, string email)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.birthday = birthday;
            this.gender = gender;
            this.passportNumber = passportNumber;
            this.nationality = nationality;
            this.email = email;
            this.avatar = avatar;
        }
    }

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string customerID { get; set; }
        private const string salt = "PasswordHashingSaltGoesHere";
        public User(string username, string password, string customerID)
        {
            this.username = username;
            this.password = password;
            this.customerID = customerID;
        }

        public static string hashPassword(string password)
        {
            SHA256 hasher = SHA256.Create();

            string input = salt + password;
            byte[] hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            
            return Convert.ToBase64String(hash);
        }

        public static bool verifyPassword(string password, string hash)
        {
            string computedHash = hashPassword(password);
            return CryptographicOperations.FixedTimeEquals(
                Convert.FromBase64String(computedHash),
                Convert.FromBase64String(hash)
            );
        }
    }

    public class Flight
    {
        public string flightID { get; set; }
        public DateTime timeDepart {  get; set; }
        public DateTime timeArrival { get; set; }
        public string flightType { get; set; }

        public Flight()
        {
            this.flightID = "NA";
        }

        public Flight(string flightID, DateTime timeDepart, DateTime timeArrival, string flightType)
        {
            this.flightID = flightID;
            this.timeDepart = timeDepart;
            this.timeArrival = timeArrival;
            this.flightType = flightType;
        }
    }

    public class FlightRegistration
    {
        public string customerID { get; set; }
        public List<Flight> flightBookedList { get; set; }

        public FlightRegistration()
        {
            this.customerID = "NA";
            this.flightBookedList = new List<Flight>();
        }

        public FlightRegistration(string customerID)
        {
            this.customerID = customerID;
            this.flightBookedList = new List<Flight>();
        }
    }
}
