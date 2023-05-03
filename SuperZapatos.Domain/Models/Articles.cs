using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperZapatos.Domain.Models
{
    public class Articles
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public float Price { get; set; }

        [Column(TypeName = "int")]
        public int Total_in_shelf { get; set; }

        [Column(TypeName = "int")]
        public int Total_in_vault { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Store_id { get; set; }
    }
}
