using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    internal interface INotification
    {
        void Notify(User user, string message);
    }
}
