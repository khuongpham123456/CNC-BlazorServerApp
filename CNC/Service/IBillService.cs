using CNC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CNC.Service
{
    public interface IBillService
    {
        IEnumerable<Bill> getAllBills();
        Bill GetBillFromId(string id);
        void UpdateStatus(string IdBill,int Status);
    }
}
