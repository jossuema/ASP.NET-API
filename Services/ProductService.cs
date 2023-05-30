using DemoTaller.Data;
using DemoTaller.Models;

namespace DemoTaller.Services
{
    public class ProductService : IProductService
    {
        private readonly StoreDBContext _context;
        public ProductService(StoreDBContext context)
        {
            this._context = context;
        }

        public void CreateProduct(ProductModel product)
        {
            _context.Products.Add(new ProductEntity
            {
                Name = product.Name,
                Stock = product.Stock,
                CreateDate = DateTime.Now,
                Description = product.Description
            });
            _context.SaveChanges();
        }

        public void UpdateProduct(ProductEntity product) {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            _context.Products.Remove(GetProduct(id));
            _context.SaveChanges();
        }

        public ProductEntity GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        public List<ProductEntity> GetAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}
