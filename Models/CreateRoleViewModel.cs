using System.ComponentModel.DataAnnotations;

namespace AuthIdentity.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name ="Role")]
        public string? RoleName { get; set; }

        [Display(Name ="Description")]
        public string? RoleDescription { get; set; }
    }
}
