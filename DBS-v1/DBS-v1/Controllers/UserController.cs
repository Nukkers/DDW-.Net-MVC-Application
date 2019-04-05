using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBS_v1.Models;
using DBS_v1.ViewModels;

namespace DBS_v1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayUsers()
        {

            var entities = new UserEntities();
            return View(entities.Users.ToList());
        }

        [HttpGet]
        public ActionResult CheckUserExists()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckUserExists(UserLoginVM model)
        {
            if (ModelState.IsValid)
            {
                var db = new UserEntities();

                var v = db.Users.Where(u => u.Username.Equals(model.Username) && u.Password.Equals(model.Password)).FirstOrDefault(); 
                if(v != null)
                {
                    ViewData["Message"] = "Login Successful";
                }
                else
                {
                    ViewData["Message"] = "Login Unsuccessful";
                }
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User model)
        {
            if (ModelState.IsValid)
            {
                var db = new UserEntities();
                db.Users.Add(new User
                {
                    Username = model.Username,
                    Email_Address = model.Email_Address,
                    Password = model.Password,
                    User_Role = "user"
                    
                });
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

    }
}