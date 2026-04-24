# Job Scheduler

A .NET-based job scheduling system designed for managing and executing background tasks efficiently. Built with C# and .NET 9.0, this project demonstrates core data structures and scheduling concepts while providing a foundation for scalable job processing.

## Features

- **Job Management**: Create, update, and track jobs with properties like priority, type, and execution status.
- **Scheduling Engine**: Supports scheduled and non-scheduled jobs with priority-based queuing.
- **Extensible Architecture**: Modular design with separate layers for models, core logic, UI, and testing.
- **Data Structure Integration**: Leverages various C# collections and custom implementations for optimal performance.
- **Testing**: Comprehensive unit tests using MSTest to ensure reliability.

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

1. Run the Console UI application:

   ```
   dotnet run --project JobScheduler.UI
   ```

2. Use the console interface to add, view, and manage jobs.

3. Run tests:
   ```
   dotnet test
   ```

For advanced usage, refer to the project documentation or explore the code in `JobScheduler.Core`.

## Project Structure

- `JobScheduler.Models/`: Data models and enums.
- `JobScheduler.Core/`: Core scheduling logic and utilities.
- `JobScheduler.UI/`: User interface for job management.
- `JobScheduler.*.Tests/`: Unit tests for each component.

## Contributing

Contributions are welcome! Please fork the repository, create a feature branch, and submit a pull request. Ensure all tests pass before submitting.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contact

For questions or feedback, reach out to [joshuapavan35@gmail.com] or open an issue on GitHub.
