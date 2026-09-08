using IceCity.EFCore.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IceCity2.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }
        

        public List<RefreshToken>? RefreshTokens { get; set; }
        public Owner? Owner { get; set; }
    }
}