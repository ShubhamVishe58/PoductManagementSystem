using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
     public interface IProductRepository
    {
        bool AddProduct(Product product);
        bool EditProduct(Product product);
        Product GetProduct(int id);
        List<Product> GetAllProducts();
        bool DeleteProduct(int id);
    }
}
