using Clothes.CORE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes.CORE.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
        List<Product> GetProductsByCategoryId(int categoryId);
        List<Product> GetProductsByUserId(int userId); // New method
        List<Product> GetProductsByOwnerId(int ownerId); // New method

    }
}
