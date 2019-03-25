using System;

namespace ReservationApp_API.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LectorId { get; set; }
        public int WeekDay { get; set; } // 1 - Monday, 2 - Tuesday ... ... 7 - Sunday
        public string TimeInterval { get; set; }
        public int Price { get; set; }
        public int HallId { get; set; }
    }
}