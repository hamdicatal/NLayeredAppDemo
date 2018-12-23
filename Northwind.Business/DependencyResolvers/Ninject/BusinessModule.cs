using Ninject.Modules;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolvers.Ninject
{
    // Oracle, MSSQL vs. ayrı ayrı business modülleri oluşturulabilir.
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            // IProductService istenirse ProductManager oluştur, onu ver.
            // Sınıflar bir kez üretildikten sonra tekrar üretilmesin diye "InSingletonScope" kullanılır. Bir nesne sadece bir sefer üretileceği için performans sağlar. Katmanlar arası geçişlerde kullanılabilir.
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }
    }
}
