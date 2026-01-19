using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProjectAPI.Data;

namespace TestProjectAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly AppDbContext _context;
    public StudentController(Data.AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult GetStudents()
    {
        var students = _context.Students.ToList();
        return Ok(students);
    }
}
