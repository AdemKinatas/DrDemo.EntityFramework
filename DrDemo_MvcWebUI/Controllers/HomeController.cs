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
    public class HomeController : Controller
    {
        IBookService _bookservice;

        public HomeController(IAppUserService appUserService, IBookService bookservice)
        {
            _bookservice = bookservice;
        }

        public ActionResult Index()
        {
            var model = _bookservice.GetBookDetailList();

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