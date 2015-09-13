using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaJo.WebAPI.Data.Model.Entities
{
   public class EntityBase : IChangeTrackedEntity
    {
       public DateTime Created
       {
           get;
           set;
       }

        public DateTime? LastUpdated
       {
           get;
           set;
       }

        public string CreatedBy
        {
            get;
            set;
        }

        public string LastUpdatedBy
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
    }
}
