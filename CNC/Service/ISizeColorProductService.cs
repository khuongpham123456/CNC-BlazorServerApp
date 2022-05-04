using CNC.Entities;
using System.Collections.Generic;

namespace CNC.Service
{
    public interface ISizeColorProductService
    {
        void AddSizeColorProduct(SizeColorProduct sizeColorProduct);
        IEnumerable<SizeColorProduct> GetResultFromIdProduct(int IdProduct);
        void DeleteFromIdProduct(int idproduct);

        SizeColorProduct CheckExistProduct(int sizeId, int colorId, int productId);

    }
}
