using System;
using System.Collections.Generic;
using System.Linq;

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
            IEnumerable<User> users = _db.Users;
            ViewBag.Users = users;
            return View();
        }

        public ActionResult UserEdit(int id)
        {
            var user = _db.Users.FirstOrDefault(u => u.Id == id);
            return View(user);
        }

        [HttpPost]
        public ActionResult UserEdit(User newUser)
        {
            var user = _db.Users.FirstOrDefault(u => u.Id == newUser.Id);
            user.Name = newUser.Name;
            user.Mail = newUser.Mail;
            _db.SaveChanges();
            ViewBag.Status = "Сохранено успешно!!!";
            return UserEdit(user.Id);
        }

        public ActionResult UserAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserAdd(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            ViewBag.Status = "Добавлен успешно!!!";
            return View();
        }
    }
}