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
    public class ProductService : IProductService
    {
        IProductDAL _productDAL;
        public ProductService(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        public bool Add(Product entity)
        {
            try
            {
                _productDAL.Add(entity);
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
                Product product = GetByID(entityID);
                _productDAL.Delete(product);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public List<Product> GetActiveProducts(bool IsActive)
        {
            return _productDAL.GetAll(a => a.IsActive == IsActive).ToList();
        }

        public List<Product> GetAll()
        {
            return _productDAL.GetAll().ToList();
        }

        public Product GetByID(int entityID)
        {
            return _productDAL.GetAll().Where(a => a.ProductID == entityID).FirstOrDefault();
        }

        public List<Product> GetHomeProducts(bool IsActive, bool IsHome)
        {
            return _productDAL.GetAll(a => a.IsActive == IsActive && a.IsHome == IsHome).ToList();
        }

        public List<Product> GetProductsByCategoryID(int categoryID)
        {
            return _productDAL.GetAll().Where(a => a.CategoryID == categoryID).ToList();
        }

        public bool Update(Product entity)
        {
            try
            {
                _productDAL.Update(entity);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
