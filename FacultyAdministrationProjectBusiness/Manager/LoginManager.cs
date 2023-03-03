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
    public class LoginManager : ILoginManager
    {
        public void CreateLogin(Login user)
        {
            using (FacultyAdministrationProjectDbContext db=new FacultyAdministrationProjectDbContext())
            {
                db.Login.Add(user);
                db.SaveChanges();
            }
        }

        public void DeleteLogin(int id)
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                var deleteduser = db.Login.Find(id);
                db.Login.Remove(deleteduser);
                db.SaveChanges();

            }
        }

        public bool EntryController(Login EntryInformations)
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                foreach (var item in db.Login.ToList())
                {
                    if (item.username == EntryInformations.username && item.password == EntryInformations.password)
                    {
                        return true;

                    }

                }
                return false;

            }
        }

        public void UpdateLogin(Login user)
        {
            using (FacultyAdministrationProjectDbContext db = new FacultyAdministrationProjectDbContext())
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
