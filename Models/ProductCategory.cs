using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Entity.Models
{
    [Table("Products_Categories")]
    public class ProductCategory
    {
        [Key]
        [Column("FK_product")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Product Product { get; set; }
        
        [Key]
        [Column("FK_category")]
        [ForeignKey("Dategory")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}