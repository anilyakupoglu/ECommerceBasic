using ETicaretBasic.BLL.Interface;
using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaretBasic.UI.MVC.Areas.Admin.Controllers
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
        public ActionResult Index()
        {
            BindCategoryDDL();
            return View(_productService.GetAll());
        }
       
        
        [HttpPost]
        public JsonResult AddProduct(Product pro)
        {
           
            bool add = _productService.Add(pro);
            if (add)
            {
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("no", JsonRequestBehavior.AllowGet);
            }
        }
        private void BindCategoryDDL()
        {
            List<SelectListItem> cat = new List<SelectListItem>();
            foreach (Category item in _categoryService.GetActiveCategories(true))
            {
                
                cat.Add(new SelectListItem()
                {
                    Text = item.CategoryName,
                    Value = item.CategoryID.ToString()
                });
            }
            ViewBag.Categories = cat;
        }
    }
}