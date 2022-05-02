using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNC.Entities;

namespace CNC.Service
{
    public interface IColorService
    {
        IEnumerable<Color> getAllColor();

        Color getColorFromId(string id);
    }
}
