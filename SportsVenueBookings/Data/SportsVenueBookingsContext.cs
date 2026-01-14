using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsVenueBookings.Configurations.Entities;
using SportsVenueBookings.Data;
using SportsVenueBookings.Domain;
using System.Drawing;

namespace SportsVenueBookings.Data
{
    public class SportsVenueBookingsContext(DbContextOptions<SportsVenueBookingsContext> options) : IdentityDbContext<SportsVenueBookingsUser>(options)
    {
        public DbSet<Booking> Booking { get; set; } = default!;
        public DbSet<Customers> Customers { get; set; } = default!;
        public DbSet<Payment> Payment { get; set; } = default!;
        public DbSet<Staff> Staff { get; set; } = default!;
        public DbSet<Venue> Venue { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new VenueSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new RoleSeed());
        }
    }
}
