using Business.Abstract;
using DrDemo_MvcWebUI.Models.ViewModels;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DrDemo_MvcWebUI.Controllers
{
    //[Authorize(Roles = "admin,user")]
    public class HomeController : Controller
    {
        IBookService _bookservice;
        ICategoryService _categoryService;

        public HomeController(IBookService bookservice, ICategoryService categoryService)
        {
            _bookservice = bookservice;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            ViewBag.Categories = _categoryService.GetList();
            var model = new BookDetailListViewModel
            {
                Books = _bookservice.GetBookDetailList()
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}