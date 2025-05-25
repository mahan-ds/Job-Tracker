using System.Text.Json.Serialization;

namespace job_manager.Models;

public class Job
{
    public int Id { get; set; } // Primary Key
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }

     //foreign key to Employer
    public int EmployerId { get; set; }

    [JsonIgnore]
    public Employer? Employer { get; set; }
}
