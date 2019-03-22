namespace ReservationApp_API.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public string HallName { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
    }
}