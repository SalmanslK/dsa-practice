// See https://aka.ms/new-console-template for more information
using SDEPrep;
using SDEPrep.Components;

Console.WriteLine("Hello, World!");

#region BreadthFirstSearch
//BreadthFirstSearch breadthFirstSearch = new BreadthFirstSearch(4);
//breadthFirstSearch.AddEdge(0, 1);
//breadthFirstSearch.AddEdge(0, 2);
//breadthFirstSearch.AddEdge(1, 2);
//breadthFirstSearch.AddEdge(2, 0);
//breadthFirstSearch.AddEdge(2, 3);
//breadthFirstSearch.AddEdge(3, 3);
//Console.Write("Following is Breadth First " + "Traversal(starting from " + "vertex 2)\n");
//breadthFirstSearch.BFS(2);
#endregion

#region DepthFirstSearch
//DepthFirstSearch depthFirstSearch = new DepthFirstSearch(4);
//depthFirstSearch.AddEdge(0, 1);
//depthFirstSearch.AddEdge(0, 2);
//depthFirstSearch.AddEdge(1, 2);
//depthFirstSearch.AddEdge(2, 0);
//depthFirstSearch.AddEdge(2, 3);
//depthFirstSearch.AddEdge(3, 3);
//Console.WriteLine("Following is Depth First Traversal " + "(starting from vertex 2)");
//depthFirstSearch.DFS(2);
//Console.ReadKey();
#endregion


#region dijkstra
/* Let us create the example
graph discussed above */
//int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
//                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
//                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
//                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
//                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
//                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
//                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
//                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
//                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
//DijkstraShortestPathGreedyAlgo7 t = new DijkstraShortestPathGreedyAlgo7();
//t.dijkstra(graph, 0);
#endregion



AWSTest AWSTest = new AWSTest();