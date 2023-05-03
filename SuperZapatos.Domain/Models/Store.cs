using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZapatos.Domain.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Address { get; set; }
    }
}
