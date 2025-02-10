using Clothes.CORE.Common;
using Clothes.CORE.Data;
using Clothes.CORE.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes.Infra.Repository
{
   public class ProductRepository : IProductRepository
    {
        private readonly IDbContext _dbContext; 

        public ProductRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetAllProducts() {

        IEnumerable<Product> result = _dbContext.Connection.Query<Product>("ProductPackage.GetAllProducts", commandType: CommandType.StoredProcedure);
           return result.ToList();
        }

        public Product GetProductById(int id)
        {
            var p = new DynamicParameters();
             p.Add("ProductId", id, dbType: DbType.Int32,direction: ParameterDirection.Input);
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("ProductPackage.GetProductById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void CreateProduct(Product product)
        {
            var p = new DynamicParameters();
            p.Add("Name", product.Name,dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Price", product.Price, dbType: DbType.Int32, direction:ParameterDirection.Input);
            p.Add("Product_Size", product.ProductSize, dbType:DbType.String, direction: ParameterDirection.Input);
            p.Add(" Color", product.Color, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Stock", product.Stock, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Image", product.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Description", product.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CategoryId", product.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Poid", product.Poid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cart_Id", product.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("ProductPackage.CreateProduct", p, commandType: CommandType.StoredProcedure);
        }


        public void DeleteProduct(int id)
        {
            var p = new DynamicParameters();
            p.Add("ProductId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result =_dbContext.Connection.ExecuteAsync("ProductPackage.DeleteProduct", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateProduct(Product product)
        {
            var p = new DynamicParameters();
            p.Add("ProductId", product.Productid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Name", product.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Price", product.Price, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Product_Size", product.ProductSize, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Color", product.Color, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Stock", product.Stock, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Image", product.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Description", product.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CategoryId", product.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Poid", product.Poid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Cart_Id", product.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("ProductPackage.UpdateProduct", p, commandType: CommandType.StoredProcedure);
        }


        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("CategoryId", categoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("ProductPackage.GetProductsByCategoryId", parameters, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Product> GetProductsByUserId(int userId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("UserId", userId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("ProductPackage.GetProductsByUserId", parameters, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Product> GetProductsByOwnerId(int ownerId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("OwnerId", ownerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("ProductPackage.GetProductsByOwnerId", parameters, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }




    }
}
