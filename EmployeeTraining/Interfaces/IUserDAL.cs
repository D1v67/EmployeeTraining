﻿using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    public interface IUserDAL
    {
        IEnumerable<User> GetAll();
        User GetByID(int id);
        void Add(User user);
        void Delete(int id);
        void Update(User user);
    }
}
