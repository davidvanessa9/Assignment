﻿using System;

namespace VisitorPattern
{
    public class BlackboardDrawerVisitor : IVisitor
    {
        
        public void Visit(Shape shape)
        {
            if (shape is Square s)
                Console.WriteLine($"Drawing square with length {s.Length} on blackboard");
            else if (shape is Circle c)
                Console.WriteLine($"Drawing circle with radius {c.Radius} on blackboard");
            else if (shape is Rectangle r)
                Console.WriteLine($"Drawing rectangle with length {r.Length} and width {r.Width} on blackboard");
            

            //Console.WriteLine($"Drawing square with length {square.Length} on blackboard");
        }

    }
}
