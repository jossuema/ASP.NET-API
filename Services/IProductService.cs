using DemoTaller.Models;

namespace DemoTaller.Services
{
    public interface IProductService
    {
        void CreateProduct(ProductModel product);
        void DeleteProduct(int id);
        List<ProductEntity> GetAllProducts();
        ProductEntity GetProduct(int id);
        void UpdateProduct(ProductEntity product);
    }
}