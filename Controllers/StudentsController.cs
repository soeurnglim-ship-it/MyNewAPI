using Microsoft.AspNetCore.Mvc;

namespace SchoolApi.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase {
        
        [HttpGet]
        public IActionResult GetStudent() {
            return Ok(new { 
                Id = 1, 
                Name = "Soeurng LIM", 
                Major = "Computer Science", 
                Position = "Teacher"
            });
        }
    }
}