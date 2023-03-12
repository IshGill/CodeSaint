using System.ComponentModel.DataAnnotations;

namespace CodeSaint.Models
{
    public class User
    {
        [Key]
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? Gender { get; set; }
        public string? Age { get; set; }
    }
}