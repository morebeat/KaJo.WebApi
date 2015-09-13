using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaJo.WebAPI.Data.Model.Entities
{
    public class Book : EntityBase
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Image { get; set; }

    }
}
