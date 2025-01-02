using BlogPost_Api.Models;
using System.ComponentModel.DataAnnotations;

namespace BlogPost_Api.Dtos
{
    public class U_post_update_Dtos
    {
        [Required]
        public string UserName { get; set; }
        [EmailAddress]
        public string UserEmail { get; set; }
        [Phone]
        public string Phone { get; set; }
        public List<BlogPostDtos> BlogPostDto { get; set; }
        public int RoleId { get; set; }

        public RoleDtos RoleDto { get; set; }
    }
}
