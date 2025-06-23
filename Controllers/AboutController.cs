using Microsoft.AspNetCore.Mvc;
using RareDiseasesAPI.Models;

namespace RareDiseasesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAboutInfo()
        {
            var about = new AboutInfo
            {
                Title = "About Rare Diseases Platform",
                Description = "This platform raises awareness and provides resources about rare diseases.",
                Mission = "Spread knowledge and help families and healthcare professionals.",
                Vision = "A world where rare diseases are better understood and treated."
            };

            return Ok(about);
        }
    }
}
