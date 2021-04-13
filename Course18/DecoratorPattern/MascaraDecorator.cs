using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class MascaraDecorator : MakeupDecorator
    {
        public MascaraDecorator(IMakeup makeup) : base(makeup) { }

        public override string GetMakeup()
        {
            string type = base.GetMakeup();
            type = type + "\nand MaxFactor mascara";
            return type;
        }
    }
}
