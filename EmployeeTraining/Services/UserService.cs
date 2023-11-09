using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTraining.Entities;
using EmployeeTraining.Interfaces;

namespace EmployeeTraining.Services
{
    public class UserService : IUserService
    {
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public void GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void RegisterNewUser(User user)
        {
            throw new NotImplementedException();
        }


        public void UserLogin(User user)
        {
            throw new NotImplementedException();
        }

        public void ApproveRegistrationRequest(Registration registration)
        {
            throw new NotImplementedException();
        }

        public void DeclineRegistrationRequest(Registration registration)
        {
            throw new NotImplementedException();
        }

        //List<User> IUserService.GetAllUser()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
