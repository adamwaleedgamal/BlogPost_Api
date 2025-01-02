using System.ComponentModel.DataAnnotations;

namespace BlogPost_Api.Dtos
{
    public class BlogPostDtos
    {
        [Required]
        public string BlogPostTitle { get; set; }
        public DateTime DateTime { get; set; }
        public List<int> numerofsubscribe { get; set; }
    }
}
