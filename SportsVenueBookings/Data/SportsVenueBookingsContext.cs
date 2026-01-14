using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsVenueBookings.Configurations.Entities;
using SportsVenueBookings.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsVenueBookings.Data
{
    public class SportsVenueBookingsContext : DbContext
    {
        public SportsVenueBookingsContext (DbContextOptions<SportsVenueBookingsContext> options)
            : base(options)
        {
        }

        public DbSet<SportsVenueBookings.Domain.Customers> Customers { get; set; } = default!;
        public DbSet<SportsVenueBookings.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<SportsVenueBookings.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<SportsVenueBookings.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<SportsVenueBookings.Domain.Venue> Venue { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new VenueSeed());
        }
    }
}
