using _6th_August_Practice.Models;

namespace _6th_August_Practice.Repository
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        Product GetProductById(int id);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProductById(int id);
    }
}