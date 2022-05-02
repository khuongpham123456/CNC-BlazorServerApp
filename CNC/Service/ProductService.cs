using CNC.Data;
using CNC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Service
{
    public class ProductService : IProductService
    {
        private ApplicationDbContext _appLicationDbContext;
        public ProductService(ApplicationDbContext appLicationDbContext)
        {
            _appLicationDbContext = appLicationDbContext;
        }
        public void addProduct(Product product)
        {
            _appLicationDbContext.Products.Add(product);
            _appLicationDbContext.SaveChanges();
        }

        public void deleteProduct(string idproduct)
        {
           Product productdelete=_appLicationDbContext.Products.FirstOrDefault(x=>x.Id == idproduct);
            _appLicationDbContext.Remove(productdelete);
            _appLicationDbContext.SaveChanges(true);
        }

        public IEnumerable<Product> getAllProductsFromId(string id)
        {
            return _appLicationDbContext.Products.Where(x => x.Name == id);
        }

        public string getNewIdProduct()
        {
            return _appLicationDbContext.Products.OrderByDescending(x => x.Id).Take(1).First().Id;
        }

        public Product getProductFromId(string id)
        {
            return _appLicationDbContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> getProductFromIdCatagory(string idcategory)
        {
            return _appLicationDbContext.Products.Where(x=>x.CategoryId==idcategory);
        }

        public void updateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatusProduct(string idproduct, int status)
        {
            Product product = getProductFromId(idproduct);
            if (product != null)
            {
                product.Status = status;
                _appLicationDbContext.SaveChanges();
            }
        }

        IEnumerable<Product> IProductService.getAllProducts()
        {
            return _appLicationDbContext.Products.ToList();
        }

    }
}
