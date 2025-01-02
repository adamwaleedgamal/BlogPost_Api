using BlogPost_Api.Dtos;
using BlogPost_Api.Repo.User_Reposiatiry;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repo;
        public UserController(IUserRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Add_all_Users(U_post_update_Dtos dtos)
        {
            _repo.Add_all_Users(dtos);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update_all_Users(int id, U_post_update_Dtos dtos)
        {
            _repo.Update_all_Users(id, dtos);
            return Ok();
        }
        [HttpDelete]
        public IActionResult delete_all_Users(int id)
        {
            _repo.delete_all_Users(id);
            return Ok();
        }

    }
}
