using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBasic.BLL.Interface
{
    public interface IProductService : IServiceBase<Product>
    {
        List<Product> GetActiveProducts(bool IsActive);
        List<Product> GetHomeProducts(bool IsActive, bool IsHome);

        List<Product> GetProductsByCategoryID(int categoryID);
    }
}
