using System;
using System.Collections.Generic;

namespace ReservationApp_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int RoleId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Created { get; set; }
        public int AccountBallacne { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public bool IsEnabled { get; set; }
    }
}