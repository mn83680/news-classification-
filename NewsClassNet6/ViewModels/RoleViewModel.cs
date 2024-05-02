using System.ComponentModel.DataAnnotations;

namespace NewsClassNet6.ViewModels
{
    public class RoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
