using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyAdministrationProjectData.entities
{
    public class Professor:Base
    {
        public string NameSurname { get; set; }
        public string Lecture { get; set; }
        public int Salary { get; set; } 
    }
}
