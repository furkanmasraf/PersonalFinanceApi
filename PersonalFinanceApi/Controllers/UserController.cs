using Microsoft.AspNetCore.Mvc;
using PersonalFinanceApi.Models;
using PersonalFinanceApi.DTOs;

namespace PersonalFinanceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>();
        private static int idCounter = 1;

        [HttpPost("register")]
        public IActionResult Register(UserDto dto)
        {
            var user = new User
            {
                Id = idCounter++,
                FullName = dto.FullName,
                Email = dto.Email,
                Password = "hashedpassword" // şimdilik dummy
            };
            users.Add(user);
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(users);
        }
    }
}
