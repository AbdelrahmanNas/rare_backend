using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RareDiseasesAPI.Data;

namespace RareDiseasesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaticPagesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StaticPagesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{title}")]
        public async Task<IActionResult> GetPageByTitle(string title)
        {
            var page = await _context.StaticPages
                .FirstOrDefaultAsync(p => p.Title.ToLower() == title.ToLower());

            if (page == null) return NotFound("❌ Page not found");

            return Ok(page);
        }
    }
}
