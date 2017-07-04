using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAplication1.Models;

namespace TestAplication1.Controllers
{
    public class UserManagerController : Controller
    {
        private readonly UserContext _userContext = new UserContext();

        // GET: Users
        public ActionResult Users()
        {
            ViewBag.Users = _userContext.Users;
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