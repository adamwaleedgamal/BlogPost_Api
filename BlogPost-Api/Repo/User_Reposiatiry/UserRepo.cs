using BlogPost_Api.Data;
using BlogPost_Api.Dtos;
using BlogPost_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPost_Api.Repo.User_Reposiatiry
{
    public class UserRepo : IUserRepo
    {
        private readonly AppdbContext _context;

        public UserRepo(AppdbContext context)
        {
            _context = context;
        }

        public void Add_all_Users(U_post_update_Dtos dtos)
        {
            var result = new User
            {
                UserName = dtos.UserName,
                UserEmail = dtos.UserEmail,
                Phone = dtos.Phone,
                Role = new Role
                {
                    RoleName = dtos.RoleDto.RoleName,
                },
                BlogPost = dtos.BlogPostDto.Select(x => new BlogPost
                {
                    BlogPostTitle = x.BlogPostTitle,
                    numerofsubscribe = x.numerofsubscribe,
                    DateTime = DateTime.UtcNow,
                }).ToList(),
            };
            _context.Users.Add(result);
            _context.SaveChanges();
        }

        public void delete_all_Users(int id)
        {
            var result = _context.Users
               .Include(x => x.Reactions)
               .Include(x => x.BlogPost)
               .Include(x => x.Role)
               .FirstOrDefault(x => x.UserId == id);
            if (result != null)
            {
                _context.Remove(result);
            }
            else
            {
                throw new Exception("User not found");
            }
            _context.SaveChanges();
        }

        public void Update_all_Users(int id, U_post_update_Dtos dtos)
        {
            var result = _context.Users.
               Include(x => x.BlogPost).
               Include(x => x.Role).
               FirstOrDefault(x => x.UserId == id);
            if (result != null)
            {
                result.UserEmail = dtos.UserEmail;
                result.Phone = dtos.Phone;
                result.UserName = dtos.UserName;
                result.BlogPost = dtos.BlogPostDto.Select(i => new BlogPost
                {
                    BlogPostTitle = i.BlogPostTitle,
                    DateTime = DateTime.UtcNow,
                    numerofsubscribe = i.numerofsubscribe,
                }).ToList();
                result.Role = new Role
                {
                    RoleName = dtos.RoleDto.RoleName,
                };
            }
            else
            {
                throw new Exception("Id Not Found");
            }
            _context.Users.Update(result);
            _context.SaveChanges();
        }

    }
}
