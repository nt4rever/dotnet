using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Model.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { set; get; }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        [Column(TypeName = "Money")]
        public decimal Price { set; get; }

        public int? CategoryId { set; get; }

        public virtual Category Category { set; get; }
    }
}
