using System;
using JobScheduler.Models.Enums;

namespace JobScheduler.Data.DTO.ResponseDTO;

public class JobResponseDTO
{
    public string? JobName { get; set; }
    public string? JobDescription { get; set; }
    public JobType? JobType { get; set; }
    public JobPriority? JobPriority { get; set; }
}
