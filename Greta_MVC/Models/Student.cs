using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Greta_MVC.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Vardas")]
        public string Vardas { get; set; }

        [Required]
        [Column("Amzius")]
        public int Amzius { get; set; }

        [Required]
        [Column("Email")]
        public string Email { get; set; }
    }
}
