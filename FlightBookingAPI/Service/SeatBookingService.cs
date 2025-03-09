namespace FlightBookingAPI.Service
{
    public class SeatBookingService
    {
        public string BookSeat(int flightId, string seatNumber)
        {
            return $"Booking seat {seatNumber} on flight {flightId}";
        }
    }
}
