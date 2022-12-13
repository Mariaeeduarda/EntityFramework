using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }   
        public Author Author { get; set; } //assumindo que o livro tem um unico autor

        //manipulation on the itens
        public override string ToString()
        {
            return $"{Title} ({PublicationYear})";
        }

    }
}
