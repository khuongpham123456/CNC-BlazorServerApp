using CNC.Data;
using CNC.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CNC.Service
{
    public class AccountService : IAccountService
    {
        private ApplicationDbContext _applicationDbContext;
        public AccountService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void DeleteAccount(Account account)
        {
            _applicationDbContext.Entry(account).State = EntityState.Deleted;
            _applicationDbContext.Accounts.Remove(account);
        }

        public Account GetAccount(int id)
        {
            return _applicationDbContext.Accounts.FirstOrDefault(a => a.Id == id);
        }

        public Account GetAccountFromAccountId(int AccountId)
        {
            return _applicationDbContext.Accounts.FirstOrDefault(x => x.Id == AccountId);
        }

        public IEnumerable<Account> GetAllAccountCustomer()
        {
            return _applicationDbContext.Accounts.Where(x => x.Permission == 1);
        }

        public IEnumerable<Account> GetAllAccountEmployee()
        {
            return _applicationDbContext.Accounts.Where(x => x.Permission == 2);
        }

        public void UpdateStatus(int id, int status)
        {
            Account account = GetAccount(id);
            if (account != null)
            {
                account.Status = status;
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
