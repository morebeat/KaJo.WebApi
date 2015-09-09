using KaJo.WebAPI.Data.SqlServer;
using KaJo.WebAPI.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaJo.WebAPI.Data.Model.Entities;

namespace KaJo.WebAPI.Tools.Initialize
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookStoreContext())
            {
                var author = new Author() { FirstName = "Jean Paul", LastName = "Sartre", Created = DateTime.Now };


                var book = new Book() { ISBN = "1234-5678-1223-12345", Title = "La rien", ShortDescription = "bla bla", LongDescription = "bla bla bla", Created = DateTime.Now };
                author.Books.Add(book);
                context.Authors.Add(author);
                context.SaveChanges();
                

            }

        }
    }
}
