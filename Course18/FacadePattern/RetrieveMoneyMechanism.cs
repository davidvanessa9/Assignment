using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class RetrieveMoneyMechanism
    {
        public void retrieve(double currentAmount, double amount)
        {
            Console.WriteLine($"Your retrieved {amount} from the card\nThe sold is now {currentAmount - amount}");
        }
    }
}
