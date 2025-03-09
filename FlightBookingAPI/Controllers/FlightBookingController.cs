using FlightBookingAPI.Service;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class FlightBookingController : ControllerBase
{
    private readonly FlightBookingFacade _bookingFacade;

    public FlightBookingController()
    {
        _bookingFacade = new FlightBookingFacade();
    }

    [HttpPost("book")]
    public IActionResult BookFlight([FromBody] FlightBookingRequest request)
    {
        var result = _bookingFacade.BookFlight(request.From, request.To, request.Date, request.FlightId, request.SeatNumber, request.CardNumber, request.Amount);
        return Ok(result);
    }
}

public class FlightBookingRequest
{
    public string From { get; set; }
    public string To { get; set; }
    public DateTime Date { get; set; }
    public int FlightId { get; set; }
    public string SeatNumber { get; set; }
    public string CardNumber { get; set; }
    public decimal Amount { get; set; }
}
