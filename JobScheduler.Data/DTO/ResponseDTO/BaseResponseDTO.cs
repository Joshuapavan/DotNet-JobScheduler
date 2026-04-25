using System;

namespace JobScheduler.Data.DTO.ResponseDTO;

public class BaseResponseDTO<T>
{
    public int StatusCode { get; set; }
    public string? Message { get; set; }

    public T? Data { get; set; }
}
