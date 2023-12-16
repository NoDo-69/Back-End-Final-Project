using System.ComponentModel.DataAnnotations;

namespace Back_End_Final_Project.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? UserName {  get; set; }
        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Password { get; set; }
        [Required]
        public double Balance {  get; set; }
    }
}
