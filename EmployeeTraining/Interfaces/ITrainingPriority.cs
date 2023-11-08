using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    internal interface ITrainingPriority
    {
         int GetTrainingPriority(User user, Training training);
    }
}
