using ETicaretBasic.BLL.Interface;
using ETicaretBasic.Entities;
using ETicaretBasic.UI.MVC.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteCategory(int catID)
        {
            bool deleted = _categoryService.DeleteByID(catID);

            if (deleted)
            {
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("no", JsonRequestBehavior.AllowGet);
            }

        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            Category cat = _categoryService.GetByID(id);
            //CategoryViewModel viewModel = new CategoryViewModel
            //{
            //    CategoryID = cat.CategoryID,
            //    CategoryName = cat.CategoryName,
            //    Description = cat.Description
            //};

            ViewBag.Cat = cat;
            return View();
        }
        [HttpPost]
        public JsonResult UpdateCategory(Category cat)
        {

            bool update = _categoryService.Update(cat);
            if (update)
            {
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("no", JsonRequestBehavior.AllowGet);
            }
        }


    }
}