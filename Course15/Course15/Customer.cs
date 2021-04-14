using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course15
{
    public class Customer : User
    {
        private string customerName;
        private string accountBalance;
        private string accountDetails;
        private string mail;
        private DateTime birthday; //use DateTime

        public Customer(string customerName, string accountBalance, string accountDetails, string mail, DateTime birthday, string id, string password):base(id, password)
        {
            this.customerName = customerName;
            this.accountBalance = accountBalance;
            this.accountDetails = accountDetails;
            this.mail = mail;
            this.birthday = birthday;
        }

        public string CustomerName { get; set; }
        public string AccountBalance { get; set; }
        public string AccountDetails { get; set; }
        public string Mail { get; set; }

        public DateTime Birthday { get; set; }

        public override string ToString()
        {
           //interpolation
            return  base.ToString()+customerName+$"\nAccount balance:{accountBalance}\nAccout details:{accountDetails}\nMail:{mail}\nBirthday: {birthday}";
        }

        public int Age()
        {
            var today = DateTime.Today;
            var age = today.Year - birthday.Year;
            return age;
        }
    }
}
