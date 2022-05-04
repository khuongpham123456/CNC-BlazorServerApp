using CNC.Data;
using CNC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Service
{
    public class CustomerService : ICustomerService
    {
        private ApplicationDbContext _applicationDbContext;
        public CustomerService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public Customer GetCustomerFromIdAccount(int id)
        {
            return _applicationDbContext.Users.FirstOrDefault(x => x.AccountId == id);
        }

        public Customer GetCustomerFromIdUser(int id)
        {
            return _applicationDbContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
