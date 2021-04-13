using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Makeup : IMakeup
    {
        public string GetMakeup()
        {
            return "This is a makeup with Fenty foundation";
        }
    }
}
