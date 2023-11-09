using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    public interface IRegistrationDAL
    {
        public void GetRegistrationById();

        public void DeleteRegistrationById();

        public void AddRegistrationById();

        public void GetAllRegistration();
    }
}
