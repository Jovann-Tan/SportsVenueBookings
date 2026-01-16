using Microsoft.AspNetCore.Identity;

namespace SportsVenueBookings.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class SportsVenueBookingsUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly DateofBirth { get; set; }
        public int Age { get; set; }
    }
}
