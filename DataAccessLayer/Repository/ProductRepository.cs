using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }


        public bool AddProduct(Product product)
        {
            _context.Products.Add(product);
            return _context.SaveChanges() > 0; 
        }

        public bool DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return false;
            }
            _context.Products.Remove(product);
            return _context.SaveChanges() > 0;
        }

        public bool EditProduct(Product product)
        {
            _context.Products.Update(product);
            return _context.SaveChanges() > 0;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
