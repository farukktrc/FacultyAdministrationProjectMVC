using FacultyAdministrationProjectBusiness.Interface;
using FacultyAdministrationProjectBusiness.Manager;
using FacultyAdministrationProjectData.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacultyAdministrationProjectUIWeb.Controllers
{
    public class ProfessorController : Controller
    {
        ProfessorManager professorManager;
        // GET: Professor
        public ActionResult Index()
        {

            professorManager = new ProfessorManager();
            List<Professor> professors = professorManager.BringProfessorsList();
            return View(professors);
           
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Professor professor)
        {
            professorManager=new ProfessorManager();
            professorManager.CreateProfessor(professor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Professor professor)
        {
            professorManager = new ProfessorManager();
            professorManager.UpdateProfessor(professor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            professorManager = new ProfessorManager();
            professorManager.DeleteProfessor(id);
            return RedirectToAction("Index");
        }
    }
}