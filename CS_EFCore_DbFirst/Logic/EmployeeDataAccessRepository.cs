using CS_EFCore_DbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EFCore_DbFirst.Logic
{
    internal class EmployeeDataAccessRepository : IDataAccessRepository<Employee, int>
    {
        Task<Employee> IDataAccessRepository<Employee, int>.CreateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        Task<Employee> IDataAccessRepository<Employee, int>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Employee>> IDataAccessRepository<Employee, int>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<Employee> IDataAccessRepository<Employee, int>.GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Employee> IDataAccessRepository<Employee, int>.UpdateAsync(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
