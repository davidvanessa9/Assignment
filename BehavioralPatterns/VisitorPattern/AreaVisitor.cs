using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class AreaVisitor : AbstractPublisher<Tuple<Shape,double>>,IVisitor
    {
        public void Visit(Shape shape)
        {
            double area = 0;

            if (shape is Square s)
            {
                area = s.Length * s.Length;
                var engineer = new Engineer();
                this.AddSubscriber(engineer);
                this.Publish(engineer, new(shape,area));
               
            } 
            else if (shape is Circle c)
            {
                area = 3.14 * c.Radius * c.Radius;
                var engineer = new Engineer();
                this.AddSubscriber(engineer);
                this.Publish(engineer, new(shape, area));
            }
            else if (shape is Rectangle r)
            {
                area = r.Width * r.Length;
                var engineer = new Engineer();
                this.AddSubscriber(engineer);
                this.Publish(engineer, new(shape, area));
            }
                
        }
    }
}
