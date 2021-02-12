using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrDemo_MvcWebUI.Controllers
{
    [Authorize(Roles = "admin,user")]
    public class BookController : Controller
    {
        IBookService _bookservice;

        public BookController(IBookService bookservice)
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