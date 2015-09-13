using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaJo.WebAPI.Data.Model.Entities
{
    public class Author : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Author()
        {
            this.Books = new List<Book>();
        }
    }
}
