using System;

namespace VisitorPattern
{
    public class PaperDrawerVisitor : IVisitor
    {
        private int capacity = 30;

        public PaperDrawerVisitor(int capacity)
        {
            this.capacity = capacity;
        }

        public void Visit(Shape shape)
        {
            if (shape is Square s)
            {
                if (capacity - s.Length < 0)
                {
                    ShowError();
                    throw new InvalidOperationException($"Current capacity {capacity} but tried to draw square of length {s.Length}");
                }
                Console.WriteLine($"Drawing square with length {s.Length} on paper");
                capacity -= s.Length;
            }
            else if (shape is Circle c)
            {
                int diameter = 2 * c.Radius;
                if (capacity - diameter < 0)
                {
                    ShowError();
                    throw new InvalidOperationException($"Current capacity {capacity} but tried to draw circle of diameter {diameter}");
                }
                Console.WriteLine($"Drawing circle with radius {c.Radius} on paper");
                capacity -= diameter;
            }
            else if (shape is Rectangle r)
            {
                int perimeter = 2 * r.Width + 2 * r.Length;
                if(capacity - perimeter < 0)
                {
                    ShowError();
                    throw new InvalidOperationException($"Current capacity {capacity} but tried to draw rectangle of perimeter {perimeter}");
                
                }
                Console.WriteLine($"Drawing rectangle with length {r.Length} and width {r.Width} on paper");
                capacity -= perimeter;
            }
        }
        
        private static void ShowError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Max capacity reached");
            Console.ResetColor();
        }
    }
}
