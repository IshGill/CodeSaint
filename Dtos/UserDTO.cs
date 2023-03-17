using System.ComponentModel.DataAnnotations;
using CodeSaint.Models;

namespace CodeSaint.Models
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }

    }
}
