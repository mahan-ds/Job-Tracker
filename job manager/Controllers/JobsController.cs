using job_manager.Data;
using job_manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace job_manager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        public readonly ApplicationDbContext _context;

        public JobsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getAll()
        {
            return Ok(_context.Jobs.ToList());
        }

        [HttpPost]
        public IActionResult createJob(Job job)
        {
            job.CreatedAt = DateTime.UtcNow;
            _context.Jobs.Add(job);
            _context.SaveChanges();
            return Ok(job);
        }

        [HttpGet("{id}")]
        public IActionResult GetJob(int id)
        {
            var job = _context.Jobs.Find(id);
            if (job == null)
            {
                return NotFound();
            }
            return Ok(job);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateJob(int id, Job updatedJob)
        {
            var job = _context.Jobs.Find(id);
            if (job == null)
            {
                return NotFound();
            }

            job.Title = updatedJob.Title;
            job.Description = updatedJob.Description;
            _context.SaveChanges();

            return Ok(job);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteJob(int id)
        {
            var job = _context.Jobs.Find(id);
            if (job == null)
            {
                return NotFound();
            }

            _context.Jobs.Remove(job);
            _context.SaveChanges();

            return NoContent(); // 204 No Content
        }

    }
}
