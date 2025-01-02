using System.ComponentModel.DataAnnotations;

namespace BlogPost_Api.Models
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }
        [Required]
        public string BlogPostTitle { get; set; }
        public DateTime DateTime { get; set; }
        public List<int> numerofsubscribe { get; set; }
        public User User { get; set; }
    }
}
