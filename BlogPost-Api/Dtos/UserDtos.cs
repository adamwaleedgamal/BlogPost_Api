using System.ComponentModel.DataAnnotations;

namespace BlogPost_Api.Dtos
{
    public class UserDtos
    {
        [Required]
        public string UserName { get; set; }
        [EmailAddress]
        public string UserEmail { get; set; }
        [Phone]
        public string Phone { get; set; }
        public List<BlogPostDtos> Posts { get; set; }
        public RoleDtos RoleDto { get; set; }
    }
}
