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
        private readonly UserContext _db = new UserContext();

        // GET: Users
        public ActionResult Users()
        {
            ViewBag.Users = _db.Users;
            return View();
        }

        public ActionResult UserEdit(int id)
        {
            var user = _db.Users.FirstOrDefault(u => u.Id == id);
            ViewBag.EditUser = user;
            return View();
        }

        public ActionResult UserAdd()
        {
            return View();
        }
    }
}