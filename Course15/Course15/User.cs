using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course15
{
    public class User
    {
        private string id;
        private string password;

        public User() { }
        public User(string id, string password)
        {
            this.id = id;
            this.password = password;
        }

        public string Id { get; set; }
        public string Password { get; set; }

        public virtual string ToString()
        {
            return $"Id:{id}\n" ;
        }
    }
}
