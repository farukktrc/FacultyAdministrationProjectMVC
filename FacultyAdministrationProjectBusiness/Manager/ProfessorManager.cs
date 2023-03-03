using FacultyAdministrationProjectBusiness.Interface;
using FacultyAdministrationProjectData.context;
using FacultyAdministrationProjectData.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyAdministrationProjectBusiness.Manager
{
    public class ProfessorManager : IProfessorManager
    {
        private object db;

        public List<Professor> BringProfessorsList()
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                List<Professor> professorList = db.Professors.ToList();
                return professorList;
            }
        }

        public void CreateProfessor(Professor professor)
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                db.Professors.Add(professor);
                db.SaveChanges();

            }



        }

        public void DeleteProfessor(int id)
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                var deletedProfessor=db.Professors.Find(id);
                db.Professors.Remove(deletedProfessor);
                db.SaveChanges();
            }
        }

        public void UpdateProfessor(Professor professor)
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                db.Entry(professor).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }


        }
    }
}
