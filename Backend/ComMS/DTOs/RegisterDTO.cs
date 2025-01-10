using System.ComponentModel.DataAnnotations;

namespace ComMS.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
        public string DepartmentCode { get; set; }
        public string Initials { get; set; }
    }

    public class LoginDTO
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool LoginFailed { get; set; }
    }
}
