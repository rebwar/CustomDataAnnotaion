using CustomDataAnnotaion.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomDataAnnotaion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController:ControllerBase
    {

        [HttpPost]
        public IActionResult CreateStudent(Student student){
            if(ModelState.IsValid){
                Student st=new();
                st=student;
                return Ok("Student has been created!");
            }
            return BadRequest();
        }
        
    }
}