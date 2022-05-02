using CNC.Entities;
using System.Collections.Generic;

namespace CNC.Service
{
    public interface IBillDetailService
    {
        public IEnumerable<BillDetail> GetBillDetailFromId(string BillId);
        public IEnumerable<BillDetail> GetListResultFromIdProduct(string IdProduct);
    }
}
