using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace job_manager.Models;

public class Job
{
    public int Id { get; set; } // Primary Key

    [Required(ErrorMessage = "Title is required")]
    [MaxLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
    public string Title { get; set; }

    [MaxLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

     //foreign key to Employer
    public int EmployerId { get; set; }

    [JsonIgnore]
    public Employer? Employer { get; set; }
}
