using System.ComponentModel.DataAnnotations;

namespace BasedProject.WebMVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
    }
}
