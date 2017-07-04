using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAplication1.Controllers
{
    public class UserManagerController : Controller
    {
        // GET: Users
        public ActionResult Users()
        {

            return View();
        }

        public ActionResult UserEdit()
        {
            return View();
        }

        public ActionResult UserAdd()
        {
            return View();
        }
    }
}