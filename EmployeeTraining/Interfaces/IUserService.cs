using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTraining.Entities;

namespace EmployeeTraining.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUser();
        void GetUserById(int id);
        void RegisterNewUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        void UserLogin(User user);

        void ApproveRegistrationRequest(Registration registration);

        void DeclineRegistrationRequest(Registration registration);

       // void ApproveRegistrationRequest(Registration registration);



    }
}
