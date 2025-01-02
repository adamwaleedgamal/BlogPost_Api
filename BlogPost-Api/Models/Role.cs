using System.ComponentModel.DataAnnotations;

namespace BlogPost_Api.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        public User User { get; set; }
    }
}
