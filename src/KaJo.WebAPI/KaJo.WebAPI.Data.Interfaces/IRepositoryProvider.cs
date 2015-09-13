using KaJo.WebAPI.Data.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaJo.WebAPI.Data.Contracts
{
    public interface IRepositoryProvider
    {
        IGenericRepository<TEntity> GetRepositoryForEntityType<TEntity>() where TEntity : EntityBase;
    }
}
