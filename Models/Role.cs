using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Entity.Models
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        [Column("PK_role")]
        public int RoleId { get; set; }

        [MaxLength(100)]
        [Column("name")]
        public string RoleName { get; set; }
    }
}