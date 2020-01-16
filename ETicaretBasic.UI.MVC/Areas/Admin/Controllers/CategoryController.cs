using ETicaretBasic.BLL.Interface;
using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaretBasic.UI.MVC.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ActionResult Index()
        {
            return View(_categoryService.GetAll());
        }

        [HttpPost]
        public JsonResult Index(Category cat)
        {
            _categoryService.Add(cat);
            return Json("ok",JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteCategory(int catID)
        {
            _categoryService.DeleteByID(catID);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }
    }
}