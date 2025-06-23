using Microsoft.AspNetCore.Mvc;
using RareDiseasesAPI.Data;
using RareDiseasesAPI.Models;

namespace RareDiseasesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SendContactMessage([FromBody] ContactMessage message)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // 📝 حفظ الرسالة في الداتابيز
            _context.ContactMessages.Add(message);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "📩 Your message has been sent successfully!",
                data = message
            });
        }
    }
}
