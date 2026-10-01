dotnet new webapi -o OrderService
cd OrderService
public class Order

{

    public int Id { get; set; }

    public int UserId { get; set; }

    public string ProductName { get; set; }

    public decimal Price { get; set; }

}[ApiController]

[Route("api/[controller]")]

public class OrdersController : ControllerBase

{

    private static readonly List<Order> Orders = new();

 

    [HttpGet]

    public ActionResult<IEnumerable<Order>> GetOrders()

    {

        return Ok(Orders);

    }

 

    [HttpPost]

    public ActionResult CreateOrder(Order order)

    {

        Orders.Add(order);

        return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, order);

    }

   

    // public Put
    // public Delete

}