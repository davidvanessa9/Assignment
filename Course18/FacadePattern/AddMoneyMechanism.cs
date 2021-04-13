using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class AddMoneyMechanism
    {
        public void addMoney(string card, double currentAmount, double amount)
        {
            Console.WriteLine($"The card {card} has {currentAmount + amount} money");
        }
    }
}
