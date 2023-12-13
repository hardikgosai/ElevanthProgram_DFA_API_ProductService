using Getri_DFA_API_ProductService.EntityFramework;
using Getri_DFA_API_ProductService.Models;

namespace Getri_DFA_API_ProductService.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly GetridfaContext dbContext;

        public ProductRepository(GetridfaContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public Product CreateProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
        }

        public bool DeleteProduct(int id)
        {
            var product = dbContext.Products.Find(id);
            if (product == null)
            {
                return false;
            }
            else
            {
                dbContext.Products.Remove(product);
                dbContext.SaveChanges();
                return true;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return dbContext.Products;
        }

        public Product SearchProduct(int id)
        {
            var product = dbContext.Products.Where(x => x.Id == id).FirstOrDefault();
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            Product product1 = dbContext.Products.Find(product.Id);
            if(product.Name != null)
            {
                product1.Name = product.Name;
            }

            if (product.Description != null)
            {
                product1.Description = product.Description;
            }

            product1.Price = product.Price;
            product1.Quantity = product.Quantity;

            dbContext.Products.Update(product1);
            dbContext.SaveChanges();
            return product1;
        }
    }
}
