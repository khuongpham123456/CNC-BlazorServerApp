using CNC.Entities;
using System.Collections.Generic;

namespace CNC.Service
{
    public interface IBillDetailService
    {
        public IEnumerable<BillDetail> GetBillDetailFromId(int BillId);
        public IEnumerable<BillDetail> GetListResultFromIdProduct(int IdProduct);
    }
}
