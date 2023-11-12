using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTraining.Entities;

namespace EmployeeTraining.Interfaces
{
    public interface IRegistrationService
    {
        IEnumerable<Registration> GetAll();
        Registration GetByID(int id);
        void Add(Registration registration);
        void Delete(int id);
        void Update(Registration registration);
    }
}
