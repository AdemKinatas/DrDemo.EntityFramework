using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrDemo_MvcWebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class HomeController : Controller
    {
        IBookService _bookservice;

        public HomeController(IBookService bookservice)
        {
            _bookservice = bookservice;
        }

        public ActionResult Index()
        {
            var model = _bookservice.GetBookDetailList();

            return View(model);
        }
    }
}