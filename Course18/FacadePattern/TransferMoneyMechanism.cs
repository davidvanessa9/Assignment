using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class TransferMoneyMechanism
    {
        public void tranfer(string card1, string card2)
        {
            Console.WriteLine($"Transfer made between {card1} and {card2}");
        }
    }
}
