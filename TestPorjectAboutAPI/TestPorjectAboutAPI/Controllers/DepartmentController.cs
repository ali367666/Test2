using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestPorjectAboutAPI.Data;
using TestPorjectAboutAPI.DTOs;
using TestPorjectAboutAPI.Entities;

namespace TestPorjectAboutAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : ControllerBase
{
    private readonly AppDbContext _context;
    public DepartmentController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult GetDepartments()
    {
        var departments = _context.Departments.ToList();
        return Ok(departments);
    }

    [HttpPost]
    public IActionResult CreateDepartment(Department department)
    {
        _context.Departments.Add(department);
        _context.SaveChanges();
        return Ok(department);
    }

    [HttpDelete]
    public IActionResult DeleteDepartment(int id)
    {
        var department=_context.Departments.Find(id);
        if(department==null)
        {
            return NotFound();
        }
        _context.Departments.Remove(department);
        _context.SaveChanges();
        return NoContent();
    }
    [HttpPut("{id}")]
    public IActionResult UpdateDepartment(int id, UpdateDepartmentDto dto)
    {
        var department = _context.Departments.Find(id);
        if (department == null)
            return NotFound();

        department.Name = dto.Name ?? department.Name;
        department.Description = dto.Description ?? department.Description;

        _context.SaveChanges();
        return Ok(department);
    }






}
