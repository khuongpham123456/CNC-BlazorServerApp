using CNC.Data;
using CNC.Entities;
using System.Collections.Generic;
using System.Linq;
namespace CNC.Service
{
    public class SizeColorProductService : ISizeColorProductService
    {
        private ApplicationDbContext _applicationDbContext;
        public SizeColorProductService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void AddSizeColorProduct(SizeColorProduct sizeColorProduct)
        {
            _applicationDbContext.SizeColorProducts.Add(sizeColorProduct);
            _applicationDbContext.SaveChanges();
        }

        public SizeColorProduct CheckExistProduct(int sizeId, int colorId, int productId)
        {
            return _applicationDbContext.SizeColorProducts.Where(x => x.ProductId == productId && x.ColorId == colorId && x.SizeId == sizeId).FirstOrDefault();
        }

        public void DeleteFromIdProduct(int idproduct)
        {
            IEnumerable<SizeColorProduct> _sizecolorproduct=GetResultFromIdProduct(idproduct);
            int length=_sizecolorproduct.Count();
            foreach(SizeColorProduct item in _sizecolorproduct)
            {
                _applicationDbContext.SizeColorProducts.Remove(item);
            }
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<SizeColorProduct> GetResultFromIdProduct(int IdProduct)
        {
            return _applicationDbContext.SizeColorProducts.Where(x => x.ProductId == IdProduct);
        }
    }
}
