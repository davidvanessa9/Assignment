using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Course18
{
    public class ConcreteService : IService
    {
        public void Register(string name, int age)
        {
            Console.WriteLine($"{name} with {age} registered succesfully");
        }
    }
}
