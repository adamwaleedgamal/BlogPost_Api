using BlogPost_Api.Dtos;
using BlogPost_Api.Models;

namespace BlogPost_Api.Repo.User_Reposiatiry
{
    public interface IUserRepo
    {
        //Task<IEnumerable<UserDtos>> PostAll(UserDtos userDtos);
        public void Add_all_Users(U_post_update_Dtos dtos);
        public void Update_all_Users(int id, U_post_update_Dtos dtos);
        public void delete_all_Users(int id);

    }
}
