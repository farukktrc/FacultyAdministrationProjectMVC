using FacultyAdministrationProjectData.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyAdministrationProjectBusiness.Interface
{
    public interface IStudentManager
    {
        List<Student> BringStudentList();
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
     
    }
}
