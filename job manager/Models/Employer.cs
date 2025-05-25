namespace job_manager.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }           
        public string ContactInfo { get; set; }    
        public List<Job> Jobs { get; set; }        
    }
}
