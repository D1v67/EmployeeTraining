using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    internal interface IAdminServices
    {
        void AddTraning(Training training);
        void EditTraning(Training training);
        void DeleteTraning(Training training);
        void ExportApprovedEmployee(Training training);

    }
}
