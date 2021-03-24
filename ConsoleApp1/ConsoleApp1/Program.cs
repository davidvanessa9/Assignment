using System;

namespace ConsoleApp1
{
    class Triangle
    {
        public int a;
        public int b;
        public int c;

        public static int count = 0;

       
        public static int perimeter(int a, int b, int c)
        {
            int p = a + b + c;
            return p;
        }

        public static void Display(int c)
        {
            Console.WriteLine(c);
        }

        //static method for counting the objects of the class
        public static int numberOfObjects()
        {
            count++;
            return count;
        }
    }

    struct rightAngle
    {
        public int l, L;
    }

    
    class Program
    {
        
        static void Adder(ref int x)
        {
            x++;
        }

        static void Adder2(out int y)
        {
           y = 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //create a Hello World program in C#

            //Reference type
            Triangle triangle = new Triangle();
            triangle.a = 4;
            triangle.b = 4;
            triangle.c = 6;
          
            Console.WriteLine("First triangle perimeter: "+Triangle.perimeter(triangle.a, triangle.b, triangle.c));
            Triangle.Display(triangle.c);
            Triangle.numberOfObjects();
            Triangle triangle1 =new Triangle();
            triangle1.b = 5;
            Console.WriteLine("Second triangle perimeter: "+Triangle.perimeter(triangle1.a, triangle1.b, triangle1.c));
            Triangle.Display(triangle1.c);
            //display the number of objects create-->using a static method
            Triangle.numberOfObjects();

            Console.WriteLine("Number of objects: " + Triangle.count);

            //use of boxing and unboxing
            int number = Triangle.count;
            object obj = number; //boxing
            Console.WriteLine(obj);
            int number2 = (int)obj; //unboxing
            Console.WriteLine(number2);


            Console.WriteLine(triangle.a + " " + triangle.b + " " + triangle.c);
            Console.WriteLine(triangle1.a + " " + triangle1.b + " " + triangle1.c);

            //Value type
            Console.WriteLine("");
            Console.WriteLine("Value type");
            rightAngle rightAngle = new rightAngle();
            rightAngle.l = 2;
            rightAngle.L = 5;
            rightAngle rightAngle1 = new rightAngle();
            rightAngle1.l = 3;
            Console.WriteLine(rightAngle.l + " " + rightAngle.L);
            Console.WriteLine(rightAngle1.l + " " + rightAngle1.L);


            //ref modifier
            int x = 3;
            Adder(ref x);
            Console.WriteLine("x after the function call with ref value: " + x);

            //out modifier
            int y = 9;
            Adder2(out y);
            Console.WriteLine("y after the function call with out value: " + y);
            Console.ReadKey();
        }
    }
}
