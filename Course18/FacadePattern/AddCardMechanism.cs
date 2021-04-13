using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class AddCardMechanism
    {
        public string Card { get; set; }
        
        public void addCardDetails(string name, int age)
        {
            Console.WriteLine($"{Card}\tname {name}\tage {age}");
        }
    }
}
