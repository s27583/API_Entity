using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Entity.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Column("PK_category")]
        public int CategoryId { get; set; }

        [MaxLength(100)]
        [Column("name")]
        public string CategoryName { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}