namespace SportsVenueBookings.Domain
{
    public class Booking : BaseDomainModel
    {
        public string? Sport { get; set; }
        public int VenueId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
    }
}
