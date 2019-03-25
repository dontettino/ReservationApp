using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservationApp_API.Models;

namespace ReservationApp_API.Data
{
    public class LessonRepository : ILessonRepository
    {
        private readonly DataContext context;
        public LessonRepository(DataContext context)
        {
            this.context = context;

        }
        public void CreateLesson(Lesson lesson)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLesson(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Lesson> GetLesson(int id)
        {
            var lesson = await this.context.Lessons.FirstOrDefaultAsync(x => x.Id == id);
            return lesson;
        }

        public async Task<IEnumerable<Lesson>> GetLessonsAsync()
        {
            var lessons = await this.context.Lessons.ToListAsync();
            return lessons;
        }

        public Task<bool> SaveAll()
        {
            throw new System.NotImplementedException();
        }
    }
}