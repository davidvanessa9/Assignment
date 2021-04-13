using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MakeupDecorator : IMakeup
    {
        private IMakeup makeup;
        
        public MakeupDecorator(IMakeup makeup)
        {
            this.makeup = makeup;
        }
        public virtual string GetMakeup()
        {
            return makeup.GetMakeup();
        }
    }
}
