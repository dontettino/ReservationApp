namespace ReservationApp_API.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LectorId { get; set; }
        public string LessonTime { get; set; }
        public int HallId { get; set; }
    }
}