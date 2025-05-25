using Microsoft.AspNetCore.Mvc;
using job_manager.Data;
using job_manager.Models;

namespace JobTrackerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public EmployersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetEmployers()
    {
        var employers = _context.Employers.ToList();
        return Ok(employers);
    }

    [HttpPost]
    public IActionResult CreateEmployer(Employer employer)
    {
        _context.Employers.Add(employer);
        _context.SaveChanges();
        return Ok(employer);
    }
}
