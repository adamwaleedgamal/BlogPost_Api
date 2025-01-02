using BlogPost_Api.Dtos;
using BlogPost_Api.Repo.Reaction_Reprosatariy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactionController : ControllerBase
    {
        private readonly IReactionRepo _repo;
        public ReactionController(IReactionRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Post(PostReationAll dto)
        {
            _repo.AddAll(dto);
            return Accepted();
        }
    }
}
