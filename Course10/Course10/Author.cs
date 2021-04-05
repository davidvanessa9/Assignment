using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course10
{
    public class Author
    {
        public string IdAuthor { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        // public List<string>Books { get; set; }
        public List<Book> Books { get; set; }
        public override string ToString() => $"{IdAuthor}, {Name}, {DateOfBirth},  {getBooks()}";
        public string getBooks()
        {
            string val = "";
            foreach(var b in Books)
            {
                val += b + " ";
            }
            return val;
        }
    }
}
