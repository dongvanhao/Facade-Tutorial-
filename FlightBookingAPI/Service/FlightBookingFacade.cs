namespace FlightBookingAPI.Service
{
    public class FlightBookingFacade
    {
        private readonly FlightSearchService _flightSearch;
        private readonly SeatBookingService _seatBooking;
        private readonly PaymentService _payment;

        public FlightBookingFacade()
        {
            _flightSearch = new FlightSearchService();
            _seatBooking = new SeatBookingService();
            _payment = new PaymentService();
        }

        public string BookFlight(string from, string to, DateTime date, int flightId, string seatNumber, string cardNumber, decimal amount)
        {
            string flightInfo = _flightSearch.SearchFlights(from, to, date);
            string seatInfo = _seatBooking.BookSeat(flightId, seatNumber);
            string paymentInfo = _payment.ProcessPayment(cardNumber, amount);

            return $"{flightInfo}\n{seatInfo}\n{paymentInfo}\n✅ Đặt vé thành công!";
        }
    }

}
