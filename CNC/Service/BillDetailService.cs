using CNC.Data;
using CNC.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CNC.Service
{
    public class BillDetailService : IBillDetailService
    {
        private ApplicationDbContext _applicationDbContext;
        public BillDetailService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        IEnumerable<BillDetail> IBillDetailService.GetBillDetailFromId(int BillId)
        {
            return _applicationDbContext.BillDetails.Where(x => x.BillId == BillId);
        }

        IEnumerable<BillDetail> IBillDetailService.GetListResultFromIdProduct(int IdProduct)
        {
            return _applicationDbContext.BillDetails.Where(x=>x.ProductId== IdProduct);
        }
    }
}
