using System.ComponentModel.DataAnnotations;

namespace Learning.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }

        [Range(0, 1000000)]
        public double Price { get; set; }
    }
}
