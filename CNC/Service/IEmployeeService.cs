using CNC.Entities;
using System.Collections.Generic;

namespace CNC.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> getAllEmployees();

        void DeleteEmployee(Employee employee);

    }
}
