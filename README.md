# C# Threading Examples

A collection of simple C# examples demonstrating threading and synchronization concepts.

## Files

| File | Concept |
|------|---------|
| `Program.cs` | Basic Thread creation with `Thread` and `ThreadStart` |
| `Program1.cs` | Async/Await with `Task.Run()` |
| `Program2.cs` | Thread safety with `lock` |
| `Program3.cs` | `ThreadPool` with `ManualResetEvent` |
| `Program4.cs` | `lock` vs `Mutex` comparison |

## Concepts Covered

- **Thread** - Manual thread creation
- **Task.Run** - Async programming
- **lock** - Simple synchronization (same process)
- **Mutex** - Cross-process synchronization
- **ThreadPool** - Efficient thread reuse
- **Join()** - Wait for thread completion
- **ManualResetEvent** - Thread signaling

## Run

```bash
dotnet run
```

## Requirements

- .NET 6.0 or later
