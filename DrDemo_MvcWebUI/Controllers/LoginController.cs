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
    public class LoginController:Controller
    {
        IAppUserService _appUserService;

        public LoginController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = _appUserService.GetList().Where(x => x.UserName == appUserVM.UserName && x.Password == appUserVM.Password).FirstOrDefault();
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, true);
                }
            }
            return RedirectToAction("Index","Home");
        }

        public ActionResult CreateAccount()
        {
            return View();
        }
    }
}