namespace SportsVenueBookings.Domain
{
    public class Venue : BaseDomainModel
    {
        public int CourtNumber { get; set; }
        public string? Address { get; set; }
        public DateTime TimeSlot { get; set; }
        public string? Availability { get; set; }
    }
}
