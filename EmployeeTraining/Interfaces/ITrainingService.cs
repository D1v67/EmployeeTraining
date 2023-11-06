using EmployeeTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTraining.Interfaces
{
    internal interface ITrainingService
    {
        List<Training> GetAllTraining();
        void GetTraningByID(int id);
        void AddTraning(Training training);
        void DeleteTraning(int id);
        void UpdateTraning(Training training);
        bool IsTrainingValid(int id);
       
    }
}
