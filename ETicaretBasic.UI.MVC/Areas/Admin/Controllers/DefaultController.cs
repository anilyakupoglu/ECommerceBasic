using ETicaretBasic.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaretBasic.UI.MVC.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        IProductService _productService;
        public DefaultController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Admin/Default
        public ActionResult Index()
        {
            return View(_productService.GetAll());
        }
      
    }
}