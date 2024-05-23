using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LastChance.Models
{
    public class User : IdentityUser
    {
        public string? Address { get; set; }

        public string? Phone { get; set; }
    }
}
