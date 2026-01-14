using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsVenueBookings.Domain;

namespace SportsVenueBookings.Configurations.Entities
{
    public class VenueSeed : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasData(
                new Venue
                {
                    Id = 1,
                    CourtNumber = 1,
                    Address = "Over Here",
                    TimeSlot = DateTime.Now,
                    Availability = "Available",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Venue
                {
                    Id = 2,
                    CourtNumber = 1,
                    Address = "Over There",
                    TimeSlot = DateTime.Now,
                    Availability = "Not Available",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Venue
                {
                    Id = 3,
                    CourtNumber = 2,
                    Address = "Under There",
                    TimeSlot = DateTime.Now,
                    Availability = "Available",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );
        }
    }
}
