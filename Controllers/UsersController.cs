using Microsoft.AspNetCore.Mvc;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Create
    [HttpPost]
    public IActionResult Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok(new { message = "User created successfully" });
    }

    // Read
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null) return NotFound(new { message = "User not found" });
        return Ok(user);
    }

    // Update
    [HttpPut("{id}")]
    public IActionResult Update(int id, User user)
    {
        var existingUser = _context.Users.Find(id);
        if (existingUser == null) return NotFound(new { message = "User not found" });
        
        existingUser.Username = user.Username;
        existingUser.Password = user.Password;
        existingUser.Role = user.Role;
        _context.SaveChanges();
        return Ok(new { message = "User updated successfully" });
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = _context.Users.ToList();
        return Ok(users); 
    }
    // Delete
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null) return NotFound(new { message = "User not found" });

        _context.Users.Remove(user);
        _context.SaveChanges();
        return Ok(new { message = "User deleted successfully" });
    }
}