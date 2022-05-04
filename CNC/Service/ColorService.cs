using CNC.Data;
using CNC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Service
{
    public class ColorService : IColorService
    {
        private ApplicationDbContext _applicationDbContext;
        public ColorService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Color> getAllColor()
        {
            return _applicationDbContext.Colors.ToList();
        }

        public Color getColorFromId(int id)
        {
            return _applicationDbContext.Colors.FirstOrDefault(x => x.Id == id);
        }
    }
}
