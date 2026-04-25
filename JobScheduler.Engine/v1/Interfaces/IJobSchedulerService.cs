using JobScheduler.Data.DTO.RequestDTO;
using JobScheduler.Data.DTO.ResponseDTO;

namespace JobScheduler.Engine.v1.Interfaces;

public interface IJobSchedulerService
{
    public BaseResponseDTO<JobResponseDTO> CreateJob(JobRequestDTO jobRequest);
    public BaseResponseDTO<object> ExecuteNext();
    public BaseResponseDTO<object> UndoLastJob();
    public BaseResponseDTO<IEnumerable<JobResponseDTO>> ShowAllJobs();
    public BaseResponseDTO<JobResponseDTO> ExecuteJobById(Guid guid);
    public BaseResponseDTO<JobResponseDTO> FindJobById(Guid guid);
}