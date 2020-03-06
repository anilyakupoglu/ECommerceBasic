using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBasic.BLL.Interface
{
    public interface ICategoryService:IServiceBase<Category>
    {
        List<Category> GetActiveCategories(bool IsActive);
    }
}
