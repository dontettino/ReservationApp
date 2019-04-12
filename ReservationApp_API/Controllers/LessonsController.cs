using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationApp_API.Data;

namespace ReservationApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private readonly ILessonRepository repo;
        public LessonsController(ILessonRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetLessons()
        {
            var users = await this.repo.GetLessons();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLesson(int id)
        {
            var user = await this.repo.GetLesson(id);

            return Ok(user);
        }
    }
}