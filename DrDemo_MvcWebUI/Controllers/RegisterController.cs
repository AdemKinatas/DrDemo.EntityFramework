using Business.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrDemo_MvcWebUI.Controllers
{
    public class RegisterController : Controller
    {
        IAppUserService _appService;

        public RegisterController(IAppUserService appService)
        {
            _appService = appService;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AppUser appUser)
        {
            _appService.Add(appUser);
            return RedirectToAction("Login","Login");
        }
    }
}