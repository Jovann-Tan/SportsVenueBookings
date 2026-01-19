namespace SportsVenueBookings.Domain
{
    public class Payment : BaseDomainModel
    {
        public long CardNumber { get; set; }
        public int Code { get; set; }
        public DateOnly Expiration { get; set; }
    }
}
