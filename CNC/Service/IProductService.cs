using CNC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Service
{
    public interface IProductService
    {
        IEnumerable<Product> getAllProducts();
        IEnumerable<Product> getAllProductsFromName(string name);
        void addProduct(Product product);
        void updateProduct(Product product);
        void deleteProduct(int idproduct);
        Product getProductFromId(int id);
        int TakeLastIDProduct(); 
        void UpdateStatusProduct(int idproduct,int status);
        IEnumerable<Product> getProductFromIdCatagory(int idcategory);
        Product findByNameProduct(string name);
    }
}
