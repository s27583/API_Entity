using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace API_Entity.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [Column("PK_product")]
        public int ProductId { get; set; }

        [MaxLength(100)]
        [Column("name")]
        public string ProductName { get; set; }

        [Column("weight")]
        public decimal ProductWeight { get; set; }

        [Column("width")]
        public decimal ProductWidth { get; set; }

        [Column("height")]
        public decimal ProductHeight { get; set; }

        [Column("depth")]
        public decimal ProductDepth { get; set; }        
        public IEnumerable<ProductCategory> ProductCategories { get; set; }        
    }
}