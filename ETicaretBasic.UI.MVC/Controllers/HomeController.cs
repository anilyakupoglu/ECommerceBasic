using ETicaretBasic.BLL.Interface;
using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaretBasic.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
           
            List<Product> product = _productService.GetHomeProducts(true, true);

            foreach (Product item in product)
            {
                item.ProductName = item.ProductName.Length > 30 ? item.ProductName.Substring(0, 27) + "..." : item.ProductName;
                item.Description = item.Description.Length > 68 ? item.Description.Substring(0, 65) + "..." : item.Description;
            }


            return View(product);
        }
   
    }
}