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
    public class AppUserController : Controller
    {
        IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public ActionResult SignIn()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SignIn(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = _appUserService.GetList().Where(x => x.UserName == appUserVM.UserName && x.Password == appUserVM.Password).FirstOrDefault();
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
                
            }
            else
            {
                return View(appUserVM);
            }
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(AppUserForSignInVM appUserForSignInVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    AppUserId = appUserForSignInVM.AppUserId,
                    FirstName = appUserForSignInVM.FirstName,
                    LastName = appUserForSignInVM.LastName,
                    UserName = appUserForSignInVM.UserName,
                    Password = appUserForSignInVM.Password,
                    Email = appUserForSignInVM.Email,
                };

                if (_appUserService.Get(au=>au.UserName==appUser.UserName)!=null || _appUserService.Get(au => au.Email == appUser.Email) != null)
                {
                    return View(appUserForSignInVM);
                }
                else
                {

                    _appUserService.Add(appUser);
                    return RedirectToAction("SignIn");
                }
            }
            else
            {
                return View(appUserForSignInVM);
            }
        }
    }
}