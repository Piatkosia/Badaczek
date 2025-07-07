using Microsoft.AspNetCore.Identity;

namespace Badaczek.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ResearchUnit { get; set; }

        public string PreferredLanguage { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginDate { get; set; }
        public string LastLoginIp { get; set; }

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
