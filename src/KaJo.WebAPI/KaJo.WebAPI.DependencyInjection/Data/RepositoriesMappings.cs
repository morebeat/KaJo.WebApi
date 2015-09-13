
using KaJo.WebAPI.Data;
using KaJo.WebAPI.Data.Contracts;
using Ninject.Modules;

namespace KaJo.WebAPI.DependencyInjection.Data
{
    public class RepositoriesMappings : NinjectModule
    {
        public override void Load()
        {
         
            Kernel.Bind<IUnitOfWork>().To(typeof(UnitOfWork));
        }
    }
}