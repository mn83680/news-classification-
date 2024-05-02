using System.ComponentModel.DataAnnotations;

namespace NewsClassNet6.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string Address { get; set; }
    }
}
