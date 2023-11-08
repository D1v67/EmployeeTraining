using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTraining.Entities;

namespace EmployeeTraining.Interfaces
{
    internal interface IRegistration
    {
        void RegisterForTraining(User user, Training training);
        void SubmitApplication();

        void UploadPrerequisites();
        List<Registration> GetAllRegistration();

        void DeleteRegistrationById(int id);

        
    }
}
