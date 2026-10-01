public class User

{

    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }
    [ApiController]

[Route("api/[controller]")]


public class UsersController : ControllerBase

{

    private static readonly List<User> Users = new();

 

    [HttpGet]

    public ActionResult<IEnumerable<User>> GetUsers()

    {

        return Ok(Users);

    }

 

    [HttpPost]

    public ActionResult CreateUser(User user)

    {

        Users.Add(user);

        return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);

    }

   

    // Додав метод для PUT та DELETE

}