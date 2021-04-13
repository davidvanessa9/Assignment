﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Engineer : ISubscriber<Tuple<Shape,double>>
    {
        
        public void Notify(Tuple<Shape, double> item)
        {
            Shape shape = item.Item1;
            double area = item.Item2;

            switch (shape)
            {
                case Square s when area < 0:
                case Circle c when area < 0:
                case Rectangle r when area < 0:
                    Console.WriteLine("Impossible area");
                    break;

                case Square s when area > 20:
                    Console.WriteLine($"Area of square with length {s.Length} is too big");
                    break;

                case Circle c when area > 30:
                    Console.WriteLine($"Area of circle with radius {c.Radius} is too big");
                    break;

                case Rectangle r when area > 15:
                    Console.WriteLine($"Area of rectangle with length {r.Length} and width {r.Width} is too big");
                    break;

                default:
                    Console.WriteLine("Seems right");
                    break;

            }

        }
    }

   
}
