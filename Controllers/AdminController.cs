using LifePartnerApp.Data;
using LifePartnerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LifePartnerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly LifePartnerContext _context;

        public AdminController(LifePartnerContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Admin admin)
        {
            var adminInDb = await _context.Admins.SingleOrDefaultAsync(a => a.Username == admin.Username && a.Password == admin.Password);
            if (adminInDb == null)
            {
                return Unauthorized();
            }
            return Ok(adminInDb);
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
    }
}
