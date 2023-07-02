using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learning.Data
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(5000)]
        public string? Description { get; set; }
        [MaxLength(100)]
        public string? Author { get; set; }
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
    }
}
