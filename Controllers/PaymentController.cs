using LifePartnerApp.Data;
using LifePartnerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifePartnerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly LifePartnerContext _context;

        public PaymentController(LifePartnerContext context)
        {
            _context = context;
        }

        [HttpPost("process")]
        public async Task<IActionResult> ProcessPayment([FromBody] Payment payment)
        {
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
            return Ok(payment);
        }
    }
}
