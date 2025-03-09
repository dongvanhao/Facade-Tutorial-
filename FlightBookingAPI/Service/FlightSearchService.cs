namespace FlightBookingAPI.Service
{
    public class FlightSearchService
    {
        public string SearchFlights(string from, string to, DateTime date)
        {
            return $"Searching for flights from {from} to {to} on {date}";
        }
    }
}
