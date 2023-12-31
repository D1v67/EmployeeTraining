﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTraining.Entities;

namespace EmployeeTraining.Interfaces
{
    public interface IUserService
    {

        IEnumerable<User> GetAll();
        User GetByID(int id);
        void Add(User user);
        void Delete(int id);
        void Update(User user);
        bool Register(User user);
        bool Login(User user);
        bool Logout(User user);
        bool ApproveRequest(User user, Training traning);
        bool DeclineRequest(User user, Training traning);
    }

    // List<User> GetAllUser();
    // void GetUserById(int id);
    // void RegisterNewUser(User user);
    // void UpdateUser(User user);
    // void DeleteUser(int id);
    // void UserLogin(User user);

    // void ApproveRegistrationRequest(Registration registration);

    // void DeclineRegistrationRequest(Registration registration);

    //// void ApproveRegistrationRequest(Registration registration);



}
}
