using Microsoft.EntityFrameworkCore;
using ReservationApp_API.Models;

namespace ReservationApp_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}