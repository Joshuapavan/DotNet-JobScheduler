using System;
using JobScheduler.Models.Enums;

namespace JobScheduler.Data.DTO.RequestDTO;

public class JobRequestDTO
{
    public required string JobName { get; set; }
    public string? JobDescription { get; set; }
    public JobType JobType { get; set; }
    public required JobPriority JobPriority { get; set; }
}
