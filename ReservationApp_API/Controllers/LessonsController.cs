using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationApp_API.Data;

namespace ReservationApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private readonly DataContext context;
        public LessonsController(DataContext context)
        {
            this.context = context;

        }
        [HttpGet]
        public async Task<IActionResult> GetLessons()
        {
            var lessons = await this.context.Lessons.ToListAsync();

            return Ok(lessons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLesson(int id)
        {
            var lesson = await this.context.Lessons.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(lesson);
        }
    }
}
