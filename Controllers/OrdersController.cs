using Microsoft.AspNetCore.Mvc;

namespace ordersAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetOrders()
    {
        // Sample data for demonstration purposes
        var orders = new List<object>
        {
            new { Id = 1, TotalAmount = 100.50},
            new { Id = 2, TotalAmount = 75.25 },
            new { Id = 3, TotalAmount = 200.00 }
        };

        return Ok(orders);
    }
}