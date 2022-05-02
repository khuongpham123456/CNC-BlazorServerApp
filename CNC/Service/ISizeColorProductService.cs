using CNC.Entities;
using System.Collections.Generic;

namespace CNC.Service
{
    public interface ISizeColorProductService
    {
        IEnumerable<SizeColorProduct> GetResultFromIdProduct(string IdProduct);
        void DeleteFromIdProduct(string idproduct);
    }
}
