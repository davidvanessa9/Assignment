using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class IlluminatorDecorator : MakeupDecorator
    {
        public IlluminatorDecorator(IMakeup makeup) : base(makeup) { }

        public override string GetMakeup()
        {
            string type = base.GetMakeup();
            type = type + "\nand Nyx Illuminator";
            return type;
        }
    }
}
