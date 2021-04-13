using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class LipstickDecorator : MakeupDecorator
    {
        public LipstickDecorator(IMakeup makeup) : base(makeup) { }

        public override string GetMakeup()
        {
            string type = base.GetMakeup();
            type = type + "\nand Huda lipstick";
            return type;
        }
    }
}
