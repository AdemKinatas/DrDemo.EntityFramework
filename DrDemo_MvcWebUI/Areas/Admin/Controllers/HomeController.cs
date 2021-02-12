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
        public ActionResult Index()
        {
            return View();
        } 
    }
}