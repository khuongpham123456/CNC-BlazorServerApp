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
        IEnumerable<Product> getAllProductsFromId(string id);
        void addProduct(Product product);
        void updateProduct(Product product);
        void deleteProduct(string idproduct);
        Product getProductFromId(string id);
        string getNewIdProduct(); 
        void UpdateStatusProduct(string idproduct,int status);
        IEnumerable<Product> getProductFromIdCatagory(string idcategory);
    }
}
