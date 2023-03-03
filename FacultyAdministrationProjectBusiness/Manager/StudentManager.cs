using FacultyAdministrationProjectBusiness.Interface;
using FacultyAdministrationProjectData.context;
using FacultyAdministrationProjectData.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyAdministrationProjectBusiness.Manager
{
    public class StudentManager : IStudentManager
    {
        public List<Student> BringStudentList()
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                List<Student> studentList = db.Students.ToList();
                return studentList;
            }

        }

        public void CreateStudent(Student student)
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                var deletedStudent = db.Students.Find(id);
                db.Students.Remove(deletedStudent);
                db.SaveChanges();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                db.Entry(student).State=System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
