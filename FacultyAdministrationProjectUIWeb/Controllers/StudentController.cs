using FacultyAdministrationProjectBusiness.Manager;
using FacultyAdministrationProjectData.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacultyAdministrationProjectUIWeb.Controllers
{
    public class StudentController : Controller
    {
        StudentManager studentManager;
        // GET: Student
        public ActionResult Index()
        {
            studentManager = new StudentManager();
            List<Student> students = studentManager.BringStudentList(); 
            return View(students);
        }

        [HttpGet]
        public ActionResult Create()
        {          
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            studentManager = new StudentManager();
            studentManager.CreateStudent(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            studentManager = new StudentManager();
            studentManager.UpdateStudent(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            studentManager = new StudentManager();
            studentManager.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}