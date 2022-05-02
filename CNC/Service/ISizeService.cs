using System;
using System.Collections.Generic;
using System.Linq;
using CNC.Entities;
using System.Threading.Tasks;

namespace CNC.Service
{
    public interface ISizeService
    {
        IEnumerable<Size> getAllSize();
        
        Size getSizeFromId(string id);

       
    }
}
