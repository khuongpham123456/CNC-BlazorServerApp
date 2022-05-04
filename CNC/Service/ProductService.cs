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

        public void deleteProduct(int idproduct)
        {
           Product productdelete=_appLicationDbContext.Products.FirstOrDefault(x=>x.Id == idproduct);
            _appLicationDbContext.Remove(productdelete);
            _appLicationDbContext.SaveChanges(true);
        }

        public IEnumerable<Product> getAllProductsFromName(string name)
        {
            return _appLicationDbContext.Products.Where(x => x.Name == name);
        }

        public Product getProductFromId(int id)
        {
            return _appLicationDbContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> getProductFromIdCatagory(int idcategory)
        {
            return _appLicationDbContext.Products.Where(x=>x.CategoryId==idcategory);
        }

        

        public void updateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatusProduct(int idproduct, int status)
        {
            Product product = getProductFromId(idproduct);
            if (product != null)
            {
                product.Status = status;
                _appLicationDbContext.SaveChanges();
            }
        }
        public int TakeLastIDProduct()
        {
            IEnumerable<Product> products = getAllProducts();
            if(products.LongCount() != 0)
            {
                return _appLicationDbContext.Products.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            }
            return 0;
        }

        public IEnumerable<Product> getAllProducts()
        {
            return _appLicationDbContext.Products.ToList();
        }

        public Product findByNameProduct(string name)
        {
            return _appLicationDbContext.Products.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}
