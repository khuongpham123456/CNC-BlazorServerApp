using CNC.Entities;
using System.Collections.Generic;
using CNC.Data;
using System.Linq;
using System.Threading.Tasks;
namespace CNC.Service
{
    public class VoucherService : IVoucherService
    {
        private ApplicationDbContext _appLicationDbContext;
        public VoucherService(ApplicationDbContext appLicationDbContext)
        {
            _appLicationDbContext = appLicationDbContext;
        }
        public IEnumerable<Voucher> getAllVouchers()
        {
            return _appLicationDbContext.Vouchers.ToList();
        }
    }
}
