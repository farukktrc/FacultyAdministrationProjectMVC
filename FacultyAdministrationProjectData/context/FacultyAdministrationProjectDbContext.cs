using FacultyAdministrationProjectData.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyAdministrationProjectData.context
{
    public class FacultyAdministrationProjectDbContext:DbContext
    {

        public FacultyAdministrationProjectDbContext()
        {
            Database.Connection.ConnectionString = "server=MSI;database=FacultyAdministration;uid=sa;pwd=1234;";
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Login> Login { get; set; }

    }
} 
