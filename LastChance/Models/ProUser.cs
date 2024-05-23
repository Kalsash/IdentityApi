using System.ComponentModel.DataAnnotations;

namespace LastChance.Models
{
    public class ProUser:User
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public required string Password { get; set; }
    }
}
