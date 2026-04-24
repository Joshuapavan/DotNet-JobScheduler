# Job Scheduler Project Plan: Learning Data Structures in C#

## Overview

This plan outlines a phased approach to building a .NET job scheduler while learning Data Structures (DS) and their methods in C#. The project starts as a skeleton with basic models and empty services, providing a clean foundation. We'll implement custom DS first for educational depth, then leverage C#'s built-in collections for efficiency. Later phases integrate Hangfire for production-ready background job processing.

**Key Goals**:

- Master core DS: Arrays, Lists, Linked Lists, Stacks, Queues, Dictionaries, Sets, Priority Queues, Trees, and Graphs.
- Build a functional job scheduler with features like job creation, queuing, priority handling, and execution.
- Emphasize testing, documentation, and incremental progress.

**Assumptions**:

- .NET 9.0 environment.
- Jobs have properties: ID (Guid), Name (string), Description (string), Priority (enum: Low/Medium/High), Type (enum: Scheduled/NonScheduled), CreatedAt (DateTime), ExecutionTime (DateTime), Status (enum: Pending/Running/Completed).
- Use MSTest for unit testing.
- Time estimate: 4-6 weeks (5-10 hours/week).

## Phase 1: Project Setup and Basic Data Structures (Arrays, Lists, Linked Lists)

**Goal**: Establish a foundation by implementing job storage and basic operations. Learn fundamental DS for dynamic storage.

**Key DS to Learn/Implement**:

- **Arrays**: Fixed-size, contiguous memory. Learn indexing, iteration, and limitations (e.g., resizing is costly).
- **Lists (Dynamic Arrays)**: C#'s `List<T>`—resizable arrays with O(1) access. Methods: Add, Remove, Insert, IndexOf.
- **Linked Lists**: Nodes linked by pointers. Learn singly/doubly linked variants. Methods: AddFirst, AddLast, Remove, Traverse.

**Implementation Steps**:

1. **Enhance the Job Model**: Add properties like `ExecutionTime` (DateTime) and `Status` (enum: Pending, Running, Completed). Update `JobScheduler.Models`.
2. **Implement Custom DS**: In `JobUtil.cs`, create classes like `CustomList<T>` (wrapping arrays) and `CustomLinkedList<T>`. Use them to store jobs in `JobSchedulerService`.
3. **Basic Job Management**: In `IJobSchedulerService`, add methods like `AddJob(Job job)`, `GetAllJobs()` (using your custom list), and `RemoveJob(Guid jobId)`.
4. **UI Basics**: In `JobScheduler.UI/Program.cs`, create a console app to add/view jobs interactively.
5. **Testing**: Write tests for DS methods (e.g., adding 100 jobs and verifying order).

**Learning Resources**:

- C# Arrays: [Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays).
- Lists: [List<T> Guide](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1).
- Linked Lists: Implement from scratch; reference [GeeksforGeeks](https://www.geeksforgeeks.org/linked-list-in-c-sharp/).

**Milestone**: A working console app that stores and lists jobs using custom DS.

## Phase 2: Stacks and Queues for Job Execution Flow

**Goal**: Introduce LIFO/FIFO structures for job processing. Simulate basic scheduling (e.g., process jobs in order).

**Key DS to Learn/Implement**:

- **Stacks**: LIFO (Last In, First Out). Methods: Push, Pop, Peek. Use for undo/redo in job operations.
- **Queues**: FIFO (First In, First Out). Methods: Enqueue, Dequeue, Peek. Ideal for job execution order.

**Implementation Steps**:

1. **Custom Implementations**: Add `CustomStack<T>` and `CustomQueue<T>` to `JobUtil.cs`. Use arrays or linked lists as backing stores.
2. **Scheduler Logic**: In `JobSchedulerService`, use a queue for pending jobs. Add methods like `EnqueueJob(Job job)`, `ProcessNextJob()` (dequeue and "execute" via console output or a timer).
3. **Job Execution**: For scheduled jobs, use `System.Timers.Timer` to trigger execution. Non-scheduled jobs can be manual.
4. **UI Enhancement**: Add menu options to enqueue jobs and view the queue.
5. **Testing**: Test queue operations (e.g., enqueue 5 jobs, dequeue and verify order).

**Learning Resources**:

- Stacks: [Stack<T> Docs](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1).
- Queues: [Queue<T> Docs](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1). Practice with LeetCode problems like "Valid Parentheses" for stacks.

**Milestone**: Jobs can be queued and processed in FIFO order, with basic execution simulation.

## Phase 3: Dictionaries and Sets for Efficient Lookup and Uniqueness

**Goal**: Optimize job retrieval and ensure uniqueness. Handle job dependencies or tags.

**Key DS to Learn/Implement**:

- **Dictionaries (Hash Tables)**: Key-value pairs. Methods: Add, Remove, TryGetValue, ContainsKey. O(1) average lookup.
- **Sets**: Unique collections. Methods: Add, Remove, Contains. Use `HashSet<T>` for fast uniqueness checks.

**Implementation Steps**:

1. **Job Storage Upgrade**: Replace lists with a dictionary in `JobSchedulerService` (key: JobID, value: Job) for O(1) lookups.
2. **Uniqueness**: Use a `HashSet<string>` for job names to prevent duplicates.
3. **Advanced Methods**: Add `GetJobById(Guid id)`, `UpdateJob(Job job)`, and search by priority/type using LINQ or custom filters.
4. **UI Features**: Add search functionality (e.g., find jobs by name or priority).
5. **Testing**: Test dictionary operations (e.g., add 1000 jobs, lookup by ID).

**Learning Resources**:

- Dictionaries: [Dictionary<TKey,TValue>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2).
- Sets: [HashSet<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1). Understand hashing and collisions.

**Milestone**: Fast job lookups and management, with uniqueness enforced.

## Phase 4: Priority Queues and Trees for Advanced Scheduling

**Goal**: Implement priority-based scheduling. Learn tree-based DS for ordered data.

**Key DS to Learn/Implement**:

- **Priority Queues**: Ordered by priority. Use heaps (binary trees). Methods: Enqueue (with priority), Dequeue (highest priority first).
- **Trees**: Binary trees, heaps. Learn traversal (inorder, preorder) and balancing.

**Implementation Steps**:

1. **Custom Priority Queue**: Implement `CustomPriorityQueue<T>` in `JobUtil.cs` using a heap (binary tree). Use `JobPriority` for ordering.
2. **Scheduler Upgrade**: Replace the basic queue with a priority queue in `JobSchedulerService`. Jobs with higher priority execute first.
3. **Tree-Based Features**: Add a binary search tree for jobs sorted by creation time.
4. **Execution Logic**: Process jobs based on priority and schedule (e.g., delay execution using `Task.Delay`).
5. **UI**: Display jobs in priority order.
6. **Testing**: Test priority ordering (e.g., enqueue high/medium/low priority jobs, verify dequeue order).

**Learning Resources**:

- Priority Queues: Implement a heap; reference [GeeksforGeeks Heap](https://www.geeksforgeeks.org/priority-queue-using-binary-heap-in-c-sharp/).
- Trees: [Binary Tree Tutorial](https://www.geeksforgeeks.org/binary-tree-data-structure/). Use `SortedSet<T>` for built-in sorted collections.

**Milestone**: Priority-based job scheduling with efficient ordering.

## Phase 5: Graphs and Advanced Features (Persistence, UI Polish)

**Goal**: Model job dependencies and add persistence. Polish the UI.

**Key DS to Learn/Implement**:

- **Graphs**: Nodes (jobs) with edges (dependencies). Methods: AddEdge, DFS/BFS traversal.
- **Advanced Collections**: `SortedDictionary<TKey,TValue>` for ordered key-value pairs.

**Implementation Steps**:

1. **Job Dependencies**: Use a graph in `JobSchedulerService` to represent job prerequisites (e.g., Job A must complete before Job B).
2. **Persistence**: Use `SortedDictionary` for in-memory storage; later, integrate a simple file-based or database persistence (e.g., JSON serialization).
3. **UI Polish**: Build a full console menu or simple WPF/Blazor UI for job management.
4. **Testing**: Test graph traversals for dependency resolution.

**Learning Resources**:

- Graphs: [Graph Data Structure](https://www.geeksforgeeks.org/graph-data-structure-and-algorithms/). Implement adjacency lists.

**Milestone**: A functional scheduler with dependencies and basic persistence.

## Phase 6: Integration with Hangfire and Final Polish

**Goal**: Replace custom scheduling with Hangfire for production-ready background jobs.

**Steps**:

1. **Learn Hangfire**: Study [Hangfire Docs](https://docs.hangfire.io/)—it's a .NET library for background job processing with persistence (SQL Server, Redis).
2. **Integration**: Add Hangfire NuGet packages. Replace custom queues with Hangfire's job storage and execution.
3. **Migration**: Refactor `JobSchedulerService` to use Hangfire's API (e.g., `BackgroundJob.Enqueue`).
4. **Testing and Deployment**: Test with real jobs; deploy as a service.

**Milestone**: A robust, scalable job scheduler using Hangfire.

## General Tips for Learning and Execution

- **Iterate and Test**: After each DS implementation, run tests and debug. Use Visual Studio's debugger for DS internals.
- **Documentation**: Update the readme.md with project progress and DS explanations.
- **Challenges**: Start with small examples (e.g., implement a queue for integers before jobs).
- **Resources**: [C# Data Structures Playlist](https://www.youtube.com/playlist?list=PL6n9fhu94yhUbctIuo9iAOmJy6_JYFQ8) on YouTube. Practice on LeetCode/HackerRank.
- **If Stuck**: Focus on one DS at a time—implement, test, then integrate.

This plan builds your scheduler progressively while covering core DS. Track progress in this file as you complete phases.