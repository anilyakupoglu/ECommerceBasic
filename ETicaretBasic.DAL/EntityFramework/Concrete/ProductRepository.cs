using ETicaretBasic.Core;
using ETicaretBasic.Core.Entities;
using ETicaretBasic.DAL.Interfaces;
using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBasic.DAL.EntityFramework.Concrete
{
    public class ProductRepository : EFRepository<Product, ETicaretDBContext>, IProductDAL
    {
    }
}
