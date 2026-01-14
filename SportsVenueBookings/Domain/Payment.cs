namespace SportsVenueBookings.Domain
{
    public class Payment : BaseDomainModel
    {
        public int CardNumber { get; set; }
        public int Code { get; set; }
        public DateOnly Expiration { get; set; }
    }
}
