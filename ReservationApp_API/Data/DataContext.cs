using Microsoft.EntityFrameworkCore;
using ReservationApp_API.Models;

namespace ReservationApp_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Lesson> Lessons { get; set; }
    }
}