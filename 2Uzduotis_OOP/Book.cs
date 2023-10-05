using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Uzduotis_OOP
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Years { get; set; }
        public string Country { get; set; }


        public Book(string name, string author, int years, string country)
        {
            Name = name;
            Author = author;
            Years = years;
            Country = country;
        }
    }
}
