using Microsoft.EntityFrameworkCore;

namespace InspimoSignalRApi.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-H67U406;initial catalog = DbSignalR;integrated security = true");

        }
        DbSet<User> Users { get; set; } 
        DbSet<Room> rooms { get; set; }

    }
}
