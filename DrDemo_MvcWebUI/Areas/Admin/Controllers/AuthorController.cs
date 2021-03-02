using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrDemo_MvcWebUI.Areas.Admin.Controllers
{
    public class AuthorController : Controller
    {
        IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public ActionResult Index()
        {
            var model = _authorService.GetAuthorDetails();
            return View(model);
        }
    }
}