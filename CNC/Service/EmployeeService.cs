using CNC.Data;
using CNC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CNC.Service
{
    public class EmployeeService : IEmployeeService
    {
        private ApplicationDbContext _appLicationDbContext;
        public EmployeeService(ApplicationDbContext appLicationDbContext)
        {
            _appLicationDbContext = appLicationDbContext;
        }

        public void DeleteEmployee(Employee employee)
        {
            _appLicationDbContext.Entry(employee).State = EntityState.Deleted;
            _appLicationDbContext.Employee.Remove(employee);
            _appLicationDbContext.SaveChanges();
        }

        public IEnumerable<Employee> getAllEmployees()
        {
            return _appLicationDbContext.Employee.ToList();
        }
    }
}
