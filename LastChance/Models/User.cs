using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LastChance.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
