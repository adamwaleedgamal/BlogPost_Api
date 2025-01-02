using System.ComponentModel.DataAnnotations;

namespace BlogPost_Api.Models
{
    public class Reaction
    {
        public int ReactionId { get; set; }
        public string ReactionName { get; set; }
        public List<User> Users { get; set; }
    }
}
