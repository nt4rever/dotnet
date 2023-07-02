using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class LINQ
    {
        public class Product
        {
            public int ID { set; get; }
            public string Name { set; get; }         // tên
            public double Price { set; get; }        // giá
            public string[] Colors { set; get; }     // các màu sắc
            public int Brand { set; get; }           // ID Nhãn hiệu, hãng
            public Product(int id, string name, double price, string[] colors, int brand)
            {
                ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
            }
            // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
            override public string ToString()
               => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";
        }

        public class Brand
        {
            public string Name { set; get; }
            public int ID { set; get; }
        }



        public void ProductPriceEqual400()
        {
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            var result = from product in products
                         from color in product.Colors
                         join brand in brands on product.Brand equals brand.ID
                         where product.Price == 400
                         where color == "Xanh"
                         orderby product.ID descending
                         select product;
            foreach (var product in result) Console.WriteLine(product.ToString());
        }

        public void ProductGroup()
        {
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            var result = from product in products
                         where product.Price >= 400 && product.Price <= 500
                         group product by product.Price into gr
                         orderby gr.Key
                         select gr;
            foreach (var product in result)
            {
                Console.WriteLine($"{product.Key} - {product.Count()}");
                foreach (var item in product)
                {
                    Console.WriteLine(item);
                }
            }

            var countGr = from product in products
                          group product by product.Price into gr
                          let count = gr.Count()
                          select new
                          {
                              price = gr.Key,
                              number_product = count
                          };
            foreach (var item in countGr)
            {
                Console.WriteLine($"{item.price} - {item.number_product}");
            }

        }
    }
}
