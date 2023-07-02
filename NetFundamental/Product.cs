using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    public class Product : IComparable<Product>, IFormattable
    {
        public int ID { set; get; }
        public string Name { set; get; }        // tên
        public double Price { set; get; }       // giá
        public string Origin { set; get; }      // xuất xứ

        public Product(int id, string name, double price, string origin)
        {
            ID = id; Name = name; Price = price; Origin = origin;
        }

        public int CompareTo(Product? other)
        {
            if (other == null) return 0;
            double delta = Price - other.Price;
            if (delta > 0) return -1;
            else if (delta < 0) return 1;
            return 0;
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            format ??= "O";
            return format.ToUpper() switch
            {
                "O" => $"Xuất xứ: {Origin} - Tên: {Name} - Giá: {Price} - ID: {ID}",
                // Tên xứ trước
                "N" => $"Tên: {Name} - Xuất xứ: {Origin} - Giá: {Price} - ID: {ID}",
                // Quăng lỗi nếu format sai
                _ => throw new FormatException("Không hỗ trợ format này"),
            };
        }

        public string ToString(string format) => ToString(format, null);

        public override string ToString() => $"{Name} - {Price}";
    }
}
