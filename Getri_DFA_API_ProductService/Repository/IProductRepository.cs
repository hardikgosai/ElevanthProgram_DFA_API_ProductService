using Getri_DFA_API_ProductService.Models;

namespace Getri_DFA_API_ProductService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product SearchProduct(int id);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        bool DeleteProduct(int id);
    }
}
