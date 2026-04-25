using JobScheduler.Data.DTO.RequestDTO;
using JobScheduler.Data.DTO.ResponseDTO;
using JobScheduler.Engine.v1.Interfaces;
using JobScheduler.Models.Enums;
using JobScheduler.Models.Models;

namespace JobScheduler.Engine.v1.Implementations;

public class JobSchedulerService : IJobSchedulerService
{
    // The api/v1/ of the application will not use hangfire or DB storage.
    // This is to learn all the DS Functionalities.
    // Note : All the data will be stored in DS and not in DB and in Synchronous format.
    public JobSchedulerService()
    {

    }

    // Data Structures
    private List<Job> JobList = new();
    private Dictionary<Guid, Job> JobMap = new();
    private Queue<Job> JobQueue = new();
    private PriorityQueue<Job, JobPriority> priorityQueue = new();
    private Stack<Job> JobHistory = new();
    private HashSet<string> JobNames = new();


    public BaseResponseDTO<JobResponseDTO> CreateJob(JobRequestDTO jobRequest)
    {
        throw new NotImplementedException();
    }

    public BaseResponseDTO<JobResponseDTO> ExecuteJobById(Guid guid)
    {
        throw new NotImplementedException();
    }

    public BaseResponseDTO<object> ExecuteNext()
    {
        throw new NotImplementedException();
    }

    public BaseResponseDTO<JobResponseDTO> FindJobById(Guid guid)
    {
        throw new NotImplementedException();
    }

    public BaseResponseDTO<IEnumerable<JobResponseDTO>> ShowAllJobs()
    {
        throw new NotImplementedException();
    }

    public BaseResponseDTO<object> UndoLastJob()
    {
        throw new NotImplementedException();
    }
}