using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Entity.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [Column("PK_account")]
        public int AccountId { get; set; }

        [MaxLength(50)]
        [Column("first_name")]        
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Column("last_name")]
        public string LastName { get; set; }

        [MaxLength(80)]
        [Column("email")]
        public string Email { get; set; }

        [MaxLength(9)]
        [Column("phone")]
        public string? Phone { get; set; }

        [ForeignKey("Role")]
        [Column("FK_role")]
        public Role Role { get; set; }

        public IEnumerable<ShoppingCart> Cart { get; set; }
    }
}