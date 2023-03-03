using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyAdministrationProjectData.entities
{
    public class Student:Base
    {
        public int StudentNumber { get; set; }
        public string NameSurname { get; set; }
        public string Branch { get; set; }
        public string Department { get; set; }
    }
}
