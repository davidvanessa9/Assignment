using System;

namespace Course18
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
           
            Console.WriteLine("-----Register-----");
            Console.WriteLine("Type your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Type your age: ");
            age = Int32.Parse(Console.ReadLine());

            IService concrete = new ConcreteService();
            IService proxy = new Proxy(concrete);
            //concrete.Register(name, age);
            proxy.Register(name, age);

            Console.ReadKey();
        }
    }
}
