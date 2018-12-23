using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            // kernel.Get ile generic metoda verilen interface karşılığı BusinessModule'de bulunur ve return edilir. (IProductService iöin ProductManager gibi)
            return kernel.Get<T>();
        }
        
    }
}
