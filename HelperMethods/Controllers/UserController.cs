﻿
using System.Web.Mvc;
using HelperMethods.Models;

namespace HelperMethods.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } // end Index()

        public ActionResult CreateUser()
        {
            return View(new User());
        } // end CreateUser() #1

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            return View(user);
        } // end CreateUser() #2 




    } // end controller
} // end namespace