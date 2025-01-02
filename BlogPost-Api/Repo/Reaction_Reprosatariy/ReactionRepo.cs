using BlogPost_Api.Data;
using BlogPost_Api.Dtos;
using BlogPost_Api.Models;

namespace BlogPost_Api.Repo.Reaction_Reprosatariy
{
    public class ReactionRepo : IReactionRepo
    {
        private readonly AppdbContext _context;

        public ReactionRepo(AppdbContext context)
        {
            _context = context;
        }

        public void AddAll(PostReationAll dto)
        {
            var result = new Reaction
            {
                ReactionName = dto.ReactionName,
                Users = dto.UsersDto.Select(x => new User
                {
                    UserName = x.UserName,
                    Phone = x.Phone,
                    UserEmail = x.UserEmail,
                    BlogPost = x.Posts.Select(t => new BlogPost
                    {
                        BlogPostTitle = t.BlogPostTitle,
                        DateTime = DateTime.UtcNow,
                        numerofsubscribe = t.numerofsubscribe,
                    }).ToList(),
                    Role = new Role
                    {
                        RoleName = x.RoleDto.RoleName,
                    }
                }).ToList(),
            };
            _context.Reactions.Add(result);
            _context.SaveChanges();
        }
    }
}
