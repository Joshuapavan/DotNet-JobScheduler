# Job Scheduler

A .NET-based job scheduling system designed for managing and executing background tasks efficiently. Built with C# and .NET 9.0, this project demonstrates core data structures and scheduling concepts while providing a foundation for scalable job processing. It's a learning project focused on implementing custom data structures (e.g., lists, queues, priority queues) before leveraging built-in .NET collections.

## Features

- **Job Management**: Create, update, and track jobs with properties like priority, type, and execution status.
- **Scheduling Engine**: Supports scheduled and non-scheduled jobs with priority-based queuing.
- **RESTful API**: ASP.NET Core Web API with Swagger documentation for job operations.
- **Data Structure Integration**: Custom implementations of DS (arrays, lists, stacks, queues, dictionaries, sets, trees, graphs) for educational purposes, transitioning to built-in collections for performance.
- **Extensible Architecture**: Modular design with separate layers for models, core logic, API, and testing.
- **Testing**: Comprehensive unit tests using MSTest to ensure reliability.
- **Future Integration**: Planned support for Hangfire in later phases for advanced background job processing.

## Prerequisites

- .NET 9.0 SDK
- Visual Studio 2022 or compatible IDE
- Basic knowledge of C# and .NET development

## Installation

1. Clone the repository:

   ```
   git clone https://github.com/your-username/DotNet-JobScheduler.git
   cd DotNet-JobScheduler
   ```

2. Restore dependencies:

   ```
   dotnet restore
   ```

3. Build the solution:
   ```
   dotnet build
   ```

## Usage

1. Run the API:

   ```
   dotnet run --project JobScheduler.API
   ```

2. Access the API:
   - Swagger UI: `https://localhost:5001/swagger` (or `http://localhost:5000` for HTTP)
   - Health Check: `GET /api/v1/healthcheck`

3. Run tests:
   ```
   dotnet test
   ```

For advanced usage, refer to the project plan in `plan.md` for phased development and data structure implementations.

## Project Structure

- `JobScheduler.Models/`: Data models (e.g., `Job`) and enums (e.g., `JobPriority`, `JobType`).
- `JobScheduler.Core/`: Core scheduling logic, interfaces (e.g., `IJobSchedulerService`), implementations, and utilities (e.g., custom DS in `JobUtil.cs`).
- `JobScheduler.API/`: ASP.NET Core Web API with controllers for job management.
- `JobScheduler.*.Tests/`: Unit tests for each component.
- `plan.md`: Detailed phased plan for learning data structures and building the scheduler.
- `readme.md`: This file.

## Contributing

Contributions are welcome! Please fork the repository, create a feature branch, and submit a pull request. Ensure all tests pass before submitting. Follow the phased plan in `plan.md` for new features.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Roadmap

- **Phase 1-5**: Implement and learn data structures, build core scheduler features.
- **Phase 6**: Integrate Hangfire for production-ready job processing.

For questions or feedback, reach out to [your-email@example.com] or open an issue on GitHub.
