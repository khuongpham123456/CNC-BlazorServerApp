using CNC.Data;
using CNC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Service
{
    public class SizeService : ISizeService
    {
        private ApplicationDbContext _applicationDbContext;
        public SizeService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Size> getAllSize()
        {
            return _applicationDbContext.Sizes.ToList();
        }

        Size ISizeService.getSizeFromId(string id)
        {
            return _applicationDbContext.Sizes.FirstOrDefault(x => x.Id == id);
        }
    }
}
