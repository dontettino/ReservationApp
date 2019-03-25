using System;

namespace ReservationApp_API.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public TimeSpan LessonStartTime { get; set; }
        public TimeSpan LessonEndTime { get; set; }
        public DateTime ReservationDate { get; set; }

    }
}