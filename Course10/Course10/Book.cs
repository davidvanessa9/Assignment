using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course10
{
    public class Book
    {
        public string IdBook { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

        public override string ToString() => $"Id = {IdBook}, {Title}, {Year}, {Category}, {Author}";
    }
}
