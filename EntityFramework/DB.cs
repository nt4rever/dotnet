using EntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class DB
    {
        public static async Task CreateDatabase()
        {
            using var dbContext = new ProductContext();
            string databaseName = dbContext.Database.GetDbConnection().Database;
            Console.WriteLine($"Create database: {databaseName}");
            bool result = await dbContext.Database.EnsureCreatedAsync();
            Console.WriteLine($"CSDL {databaseName} : {result}");
        }

        public static async Task DeleteDatabase()
        {
            using var dbContext = new ProductContext();
            string databaseName = dbContext.Database.GetDbConnection().Database;
            bool deleted = await dbContext.Database.EnsureDeletedAsync();
            Console.WriteLine($"{databaseName} {deleted}");
        }

        public static async Task InsertProduct()
        {
            using var dbContext = new ProductContext();
            await dbContext.AddAsync(new Product
            {
                Name = "Sản phẩm 1",
                Provider = "Công ty 1"
            });
            await dbContext.AddAsync(new Product()
            {
                Name = "Sản phẩm 2",
                Provider = "Công ty 1"
            });
            int rows = await dbContext.SaveChangesAsync();
            Console.WriteLine(rows);
        }

        public static async Task QueryProduct()
        {
            using var dbContext = new ProductContext();
            var products = await (from p in dbContext.Products where p.ProductId == 1 select p).ToListAsync();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductId,2} {product.Name,10} - {product.Provider}");
            }
        }

        public static async Task UpdateProduct()
        {
            using var dbContext = new ProductContext();
            var product = await (from p in dbContext.Products where p.ProductId == 1 select p).FirstOrDefaultAsync();
            if (product != null)
            {
                product.Name = "Tan villa";
                await dbContext.SaveChangesAsync();
            }
        }
        
    }
}
