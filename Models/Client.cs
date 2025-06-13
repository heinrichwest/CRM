using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public string CompanyWebsite { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string LastFeedback { get; set; } = string.Empty;
    }
}
