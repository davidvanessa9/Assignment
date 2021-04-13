using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Course18
{
    public class Proxy : IService
    {
        private IService service;

        public Proxy(IService service)
        {
            this.service = service;
        }
        public void Register(string name, int age)
        {

            if (!Regex.Match(name, "^[A-Z][a-zA-Z]*$").Success)
            {
                Console.WriteLine("Invalid name!");
            }
            else if (age < 18)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                service.Register(name, age);
            }


        }
    }
}
