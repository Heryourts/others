using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Genre Genre { get; set; }


        public Customer(string name, string email, Genre genre)
        {
            Name = name;
            Email = email;  
            Genre = genre;
        }
    }
}
