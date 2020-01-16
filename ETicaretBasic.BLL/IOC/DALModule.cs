using ETicaretBasic.DAL.EntityFramework.Concrete;
using ETicaretBasic.DAL.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBasic.BLL.IOC
{
    public class DALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryDAL>().To<CategoryRepository>();
            Bind<IProductDAL>().To<ProductRepository>();
        }
    }
}
