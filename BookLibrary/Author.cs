using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public ICollection<Book> Books { get; set;} // interface o sistema pode escolher qual o melhor tipo de coleção dependendo se o book are in memory or still stored in the database

        public override string ToString()
        {
            return Name ;
        }
    }
}
