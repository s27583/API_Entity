using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Entity.Models
{
    [Table("Shopping_Carts")]
    public class ShoppingCart
    {
        [Key]
        [Column("FK_account")]
        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

        [Key]
        [Column("FK_product")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        [Column("amount")]
        public int Amount { get; set; }
        
    }
}