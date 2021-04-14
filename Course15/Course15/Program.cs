using System;
using System.IO;

namespace Course15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] part;
            User user = new User();
            Customer customer;
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\Course15\Course15\customer.txt")) //empty strings
                {
                    string line;
                    while (!string.IsNullOrEmpty(line = sr.ReadLine()))
                    {
                        part = line.Split(",");
                        string id = part[0];
                        string password = part[1];
                        string name = part[2];
                        string balance = part[3];
                        string details = part[4];
                        string mail = part[5];
                        string[] data = part[6].Split("-");
                        string day = data[0];
                        string month = data[1];
                        string year = data[2];

                        customer = new Customer(name, balance, details, mail, new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day) ), id, password);
                        Console.WriteLine(customer.ToString());

                        int age = customer.Age();
                        if(age > 18)
                        {
                            Console.WriteLine("\n\nEligible for register");
                        }
                        else
                        {
                            Console.WriteLine("\n\nNOT eligible");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
