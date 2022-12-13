using BookLibrary;
using DBFirstLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework
{
    class Program // selection of books
        //we put 2gheter classes that are then gonna be turned into tables in our database
    {
        static IEnumerable<Author> CreateFakeData()
        {
            var author = new List<Author>
            {
                new Author
                {
                    Name = "Agatha Christie" , Books = new List<Book>
                    {
                        new Book {Title = "After the Funeral", PublicationYear = 1895 },
                        new Book {Title = "The Clocks", PublicationYear = 1818 },
                        new Book {Title = "The Hollow" , PublicationYear = 1836}
                    }
                },
                new Author
                {
                    Name = "Ian Flening", Books = new List<Book>
                    {
                        new Book {Title = "Dr No", PublicationYear = 1958},
                        new Book {Title = "Goldfinger", PublicationYear = 1959},
                        new Book {Title = "From Russia with Love", PublicationYear = 1957},
                    }
                }
            };
            return author;
        }
        static void Main()
        {
            //criar as options que vai passar into our DBContext
            var options = new DbContextOptionsBuilder<MyLocalLibraryContext>()
                .UseSqlite("Filename=../../../MyLocalLibrary.db")
                .Options;
            using var db = new MyLocalLibraryContext(options);

            db.Database.EnsureCreated(); // its cause is gonna be the first time that we run it that will actually create the database m/**/

            //var authors = CreateFakeData();

            //db.Authors.AddRange(authors);
            //db.SaveChanges();   // until i do a savechanges anything ive done is only in memory 

            var recentBooks = from b in db.Books where b.PublicationYear > 1900 select b;

            foreach (var book in recentBooks.Include(b => b.Author)) // pegar os authores e seus livros, se nao colocar author nofim apenas vai pegar os books 
            {
                Console.WriteLine($"{book} is by {book.Author}");
                
            }
        }
    }
} 