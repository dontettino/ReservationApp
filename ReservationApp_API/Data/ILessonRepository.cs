using System.Collections.Generic;
using System.Threading.Tasks;
using ReservationApp_API.Models;

namespace ReservationApp_API.Data
{
    public interface ILessonRepository
    {
        void CreateLesson(Lesson lesson);
        // void DeleteLesson(string lesson); TODO
        void DeleteLesson(int id);
        Task<Lesson> GetLesson(int id);
        Task<IEnumerable<Lesson>> GetLessonsAsync();
        Task<bool> SaveAll();
    }
}