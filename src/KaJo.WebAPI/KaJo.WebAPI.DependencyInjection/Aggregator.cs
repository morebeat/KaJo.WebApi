using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using KaJo.WebAPI.DependencyInjection.Data;

namespace KaJo.WebAPI.DependencyInjection
{
    public static class Aggregator
    {
        public static INinjectModule[] Mappings
        {
            get
            {
                return new INinjectModule[]
                {
                    new RepositoriesMappings()
                };
            }
        }

    }
}
