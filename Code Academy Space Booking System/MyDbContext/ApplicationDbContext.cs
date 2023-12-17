using System;
using Code_Academy_Space_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Code_Academy_Space_Booking_System.MyDbContext
{
	public class ApplicationDbContext:DbContext 
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localhost); Initial Catalog=MakeenProject; Integrated Security=True;");
        }

        public DbSet<Space> Spaces { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
