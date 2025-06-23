using System.ComponentModel.DataAnnotations;

namespace RareDiseasesAPI.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        [StringLength(1000, ErrorMessage = "Message can't be longer than 1000 characters.")]
        public string? Message { get; set; }

        public DateTime SentAt { get; set; } = DateTime.UtcNow;
    }
}
