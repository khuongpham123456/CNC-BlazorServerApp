using CNC.Data;
using CNC.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CNC.Service
{
    public class BillService : IBillService
    {
        private ApplicationDbContext _appLicationDbContext;
        public BillService(ApplicationDbContext appLicationDbContext)
        {
            _appLicationDbContext = appLicationDbContext;
        }
        public IEnumerable<Bill> getAllBills()
        {
            return _appLicationDbContext.bills.ToList();
        }
        public Bill GetBill(int id)
        {
            return _appLicationDbContext.bills.FirstOrDefault(x => x.Id == id);
        }

        public Bill GetBillFromId(int id)
        {
            return _appLicationDbContext.bills.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateStatus(int IdBill, int Status)
        {

            /*var bill = new Bill()
            {
                Id = IdBill,
                StatusBill = Status
            };
            _appLicationDbContext.bills.Attach(bill);
            _appLicationDbContext.Entry(bill).Property(x => x.StatusBill).IsModified = true;
            _appLicationDbContext.SaveChanges();*/
            Bill bill = GetBill(IdBill);
            if (bill != null)
            {
                bill.StatusBill = Status;
                _appLicationDbContext.SaveChanges();
            }
            
            
        }
    }
}
