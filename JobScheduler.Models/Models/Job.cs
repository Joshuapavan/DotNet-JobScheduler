using JobScheduler.Models.Enums;

namespace JobScheduler.Models.Models;

public class Job
{
    public required Guid JobID { get; set; } = Guid.NewGuid();
    public required string JobName { get; set; }
    public string? JobDescription { get; set; }
    public int Priority { get; set; }
    public DateTime CreatedAt { get; set; }

    public JobType JobType { get; set; }
    public required JobPriority JobPriority { get; set; }
}