using System.ComponentModel.DataAnnotations;

namespace LastChance.Models
{
    public class Person:User
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public required string Password { get; set; }
    }
}
