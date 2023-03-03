using FacultyAdministrationProjectBusiness.Manager;
using FacultyAdministrationProjectData.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FacultyAdministrationProjectUIWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        LoginManager loginManager;

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(Login login)
        {
            loginManager = new LoginManager();
            loginManager.EntryController(login);
            return RedirectToAction("Index","Student");
        }
    }
}