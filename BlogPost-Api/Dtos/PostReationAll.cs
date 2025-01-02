using BlogPost_Api.Models;

namespace BlogPost_Api.Dtos
{
    public class PostReationAll
    {
        public string ReactionName { get; set; }
        public List<UserDtos> UsersDto { get; set; }
    }
}
