using EmployeeTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Entities
{
    public class Registration: IRegistration
    {
        private string ManagerId { get; set; }
        private string DepartmentName { get; set; }

        private List<Registration> ListOfPrerequisites { get; set; }

        public void DeleteRegistrationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Registration> GetAllRegistration()
        {
            throw new NotImplementedException();
        }

        public void RegisterForTraining(User user, Training training)
        {
            throw new NotImplementedException();
        }

        public void SubmitApplication()
        {
            throw new NotImplementedException();
        }

        public void UploadPrerequisites()
        {
            throw new NotImplementedException();
        }


        //add application

    }
}
