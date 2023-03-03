using FacultyAdministrationProjectData.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyAdministrationProjectBusiness.Interface
{
    public interface ILoginManager
    {
        bool EntryController(Login EntryInformations);
        void CreateLogin(Login user);
        void UpdateLogin(Login user);
        void DeleteLogin(int id);


    }
}
