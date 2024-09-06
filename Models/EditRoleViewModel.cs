using System.ComponentModel.DataAnnotations;

namespace AuthIdentity.Models
{
    public class EditRoleViewModel
    {
        [Required]
        public string? Id { get; set; }

        [Required(ErrorMessage ="Role Name is Requiered")]
        public string? RoleName { get; set; }
        public string? RoleDescription { get; set; }
        public List<string>? Users { get; set; }
    }
}
