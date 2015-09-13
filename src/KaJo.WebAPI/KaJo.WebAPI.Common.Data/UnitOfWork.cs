using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using KaJo.WebAPI.Data.Contracts;
using KaJo.WebAPI.Data.Model.Entities;

namespace KaJo.WebAPI.Data
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        #region Members

        protected IRepositoryProvider RepositoryProvider { get; set; }
        private readonly DbContext _context;

        #endregion

        #region Properties

     

        #endregion 


        public UnitOfWork(DbContext context, IRepositoryProvider repositoryProvider)
        {
            if (context == null) throw new ArgumentNullException("context");

            RepositoryProvider = repositoryProvider;

            _context = context;
        }


        public IGenericRepository<T> GetStandardRepository<T>() where T : EntityBase
        {
            return (RepositoryProvider.GetRepositoryForEntityType<T>());
        }


        public void Save()
        {
            
            _context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
