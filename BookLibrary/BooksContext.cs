using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{  
    //our connection point to the database itself : is where the real work of the database connection happens 
    public class BooksContext : DbContext    // as classes vao ser representada por tabelas no database 
    {
      //Construtores, vao prover rules about how it actually connects to the database 
      public BooksContext(DbContextOptions<BooksContext> options)
             : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get;set; }
    }
}
