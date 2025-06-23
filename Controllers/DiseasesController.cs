using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RareDiseasesAPI.Data;
using RareDiseasesAPI.Models;
using System.Linq.Dynamic.Core; // 👈 مهم عشان نعمل Dynamic Sorting

namespace RareDiseasesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiseasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DiseasesController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ عرض كل الأمراض مع Pagination + Sorting
        [HttpGet]
        public async Task<IActionResult> GetAllDiseases(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string orderBy = "Name",
            [FromQuery] bool isDescending = false)
        {
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0) pageSize = 10;

            var totalDiseases = await _context.Diseases.CountAsync();

            var query = _context.Diseases.AsQueryable();

            // 🛠️ ترتيب ديناميكي حسب الطلب
            var sorting = isDescending ? $"{orderBy} descending" : $"{orderBy}";

            var diseases = await query
                .OrderBy(sorting)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var response = new
            {
                TotalItems = totalDiseases,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalDiseases / (double)pageSize),
                Data = diseases
            };

            return Ok(response);
        }

        // ✅ عرض تفاصيل مرض واحد
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiseaseById(int id)
        {
            var disease = await _context.Diseases.FindAsync(id);
            if (disease == null) return NotFound("❌ Disease not found");
            return Ok(disease);
        }

        // ✅ بحث في الأمراض مع Pagination + Sorting
        [HttpGet("search")]
        public async Task<IActionResult> SearchDiseases(
            [FromQuery] string keyword,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string orderBy = "Name",
            [FromQuery] bool isDescending = false)
        {
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0) pageSize = 10;

            var query = _context.Diseases
                .Where(d => d.Name.Contains(keyword) || d.Symptoms.Contains(keyword));

            var totalResults = await query.CountAsync();

            var sorting = isDescending ? $"{orderBy} descending" : $"{orderBy}";

            var diseases = await query
                .OrderBy(sorting)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var response = new
            {
                TotalItems = totalResults,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalResults / (double)pageSize),
                Data = diseases
            };

            return Ok(response);
        }
    }
}
