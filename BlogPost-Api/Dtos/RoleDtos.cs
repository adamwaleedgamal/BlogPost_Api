using System.ComponentModel.DataAnnotations;

namespace BlogPost_Api.Dtos
{
    public class RoleDtos
    {

        [Required]
        public string RoleName { get; set; }
    }
}
