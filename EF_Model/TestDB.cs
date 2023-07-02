using EF_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Model
{
    public class TestDB
    {
        public async Task InsertSample()
        {
            using var dbContext = new ShopContext();
            var cate1 = new Category() { Name = "Laptop", Description = "this is laptop" };
            var cate2 = new Category() { Name = "Mobile", Description = "this is iphone" };
            await dbContext.AddRangeAsync(cate1, cate2);
            await dbContext.SaveChangesAsync();
            await dbContext.products.AddRangeAsync(
                new Product() { Name = "Acer swift 3 evo", Price = 100000, Category = cate1 },
                new Product() { Name = "Lenovo ideaPad", Price = 900000, Category = cate1 },
                new Product() { Name = "IPhone 14 pro max", Price = 920000, Category = cate2 }
                );
            await dbContext.SaveChangesAsync();
            foreach (var item in dbContext.products)
            {
                StringBuilder str = new();
                str.Append($"ID: {item.ProductId} ");
                str.Append($"Name: {item.Name} ");
                str.Append($"Category: {item.CategoryId}({item.Category.Name})");
                Console.WriteLine(str.ToString());
            }
        }

        public async Task<Product> FindProduct(int id)
        {
            var dbConext = new ShopContext();
            var item = await (from p in dbConext.products where p.ProductId == id select p).FirstOrDefaultAsync();
            //await dbConext.Entry(item).Reference(x => x.Category).LoadAsync();
            return item;
        }

        public async Task<Category> FindCategory(int id)
        {
            var dbConext = new ShopContext();
            var item = await (from c in dbConext.categories where c.CategoryId == id select c).FirstOrDefaultAsync();
            //await dbConext.Entry(item).Collection(cc => cc.Products).LoadAsync();
            return item;
        }
    }
}
