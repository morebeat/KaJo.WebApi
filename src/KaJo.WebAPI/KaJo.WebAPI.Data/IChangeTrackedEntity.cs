using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaJo.WebAPI.Data.Model
{
   public interface IChangeTrackedEntity : IEntity
    {
         DateTime Created { get; set; }
         DateTime? LastUpdated { get; set; }
         string CreatedBy { get; set; }
         string LastUpdatedBy { get; set; }
    }
}
