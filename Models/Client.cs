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
    }
}
