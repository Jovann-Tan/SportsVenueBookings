namespace SportsVenueBookings.Domain
{
    public class Customers : BaseDomainModel
    {
        public string? Name { get; set; }
        public int ContactNumber { get; set; }
        public string? Email { get; set; }
    }
}
