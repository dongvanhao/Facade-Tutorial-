namespace FlightBookingAPI.Service
{
    public class PaymentService
    {
        public string ProcessPayment(string cardNumber, decimal amount)
        {
            return $"Processing payment of {amount} with card number {cardNumber}";
        }
    }
}
