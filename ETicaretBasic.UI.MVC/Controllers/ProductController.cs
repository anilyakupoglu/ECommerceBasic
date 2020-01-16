using ETicaretBasic.BLL.Interface;
using ETicaretBasic.BLL.Services;
using ETicaretBasic.Entities;
using ETicaretBasic.UI.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaretBasic.UI.MVC.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
  
        public ActionResult Details(int id)
        {
          
            Product product = _productService.GetByID(id);

            ProductViewModel productView = new ProductViewModel()
            {
                CategoryID = product.CategoryID,
                Description = product.Description,
                Image = product.Image,
                Price = product.Price,
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                Stock = product.Stock,
                Category = product.Category
            };

            return View(productView);
        }
        public ActionResult List(int id = 0)
        {
            List<Product> products = _productService.GetActiveProducts(true);
            foreach (Product item in products)
            {
                item.ProductName = item.ProductName.Length > 30 ? item.ProductName.Substring(0, 27) + "..." : item.ProductName;
                item.Description = item.Description.Length > 68 ? item.Description.Substring(0, 65) + "..." : item.Description;
            }

            if (id != 0)
            {
                products = _productService.GetProductsByCategoryID(id);
            }

            return View(products);
        }
        public PartialViewResult GetCategories()
        {
            return PartialView(_categoryService.GetAll());
        }

    }
}