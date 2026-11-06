# DSA Practice

C# practice code for data structures and algorithms (.NET 6 console app).

| File in `SDEPrep/` | What it covers |
| --- | --- |
| `Components/BreadthFirstSearch.cs` | Breadth-first traversal of a directed graph, using an adjacency list |
| `Components/DepthFirstSearch.cs` | Depth-first traversal, from one vertex or across a disconnected graph |
| `Components/DijkstraShortestPathGreedyAlgo7.cs` | Dijkstra's shortest paths on a 9-vertex adjacency matrix |
| `Test.cs` | Two coding exercises: combining package weights, and a nested-loop sum over a list of power values |

## Run

Requires the .NET 6 runtime, or a newer SDK with it installed.

```
dotnet run --project SDEPrep
```

This prints `Hello, World!` and runs the `Test.cs` exercises without printing their results. To see a graph
algorithm's output, uncomment its example in `SDEPrep/Program.cs` and run it again.
