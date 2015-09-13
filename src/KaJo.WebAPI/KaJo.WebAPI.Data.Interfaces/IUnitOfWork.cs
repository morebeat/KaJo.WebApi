using KaJo.WebAPI.Data.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaJo.WebAPI.Data.Contracts
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> GetStandardRepository<T>() where T : EntityBase;
        void Save();
        void Dispose();
    }
}
