using System;
using System.IO;
using System.Collections.Generic;

namespace Course14
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"D:\\Faculta\\Course14\\Course14\\write.txt");
         
            int option = 1;
            string addedLine;
            List<string> line = new List<string>();
            while (option != 0)
            {
                Console.WriteLine("Type a text:");
                addedLine = Console.ReadLine();
                if (addedLine == "0")
                { option = 1; break; }

                else
                {
                    line.Add(addedLine);
                }
                
            }

            foreach (var l in line)
            {
                sw.WriteLine(l);
            }

            sw.Close();

            string[] linesFile = System.IO.File.ReadAllLines(@"D:\\Faculta\\Course14\\Course14\\write.txt");
            foreach(var l in linesFile)
            {
                Console.WriteLine(l);
            }
        }
    }
}
