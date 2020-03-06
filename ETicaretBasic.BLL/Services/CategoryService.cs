using ETicaretBasic.BLL.Interface;
using ETicaretBasic.DAL.Interfaces;
using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBasic.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryDAL _catDAL;
        public CategoryService(ICategoryDAL categoryDAL)
        {
            _catDAL = categoryDAL;
        }
        public bool Add(Category entity)
        {
            try
            {
                _catDAL.Add(entity);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public bool DeleteByID(int entityID)
        {
            try
            {
                Category cat = GetByID(entityID);
                _catDAL.Delete(cat);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
      
        }
        public List<Category> GetActiveCategories(bool IsActive)
        {
            return _catDAL.GetAll(a => a.IsActive == IsActive).ToList();
        }
        public List<Category> GetAll()
        {
            return _catDAL.GetAll().ToList();
        }

        public Category GetByID(int entityID)
        {
            return _catDAL.Get(a => a.CategoryID == entityID);
        }



        public bool Update(Category entity)
        {
            try
            {
                _catDAL.Update(entity); 
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
