using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDEPrep.Components
{
    public class DepthFirstSearch
    {
		private int V; // No. of vertices

		// Array of lists for
		// Adjacency List Representation
		private List<int>[] adj;

		// Constructor
		// Graph
		public DepthFirstSearch(int v)
		{
			V = v;
			adj = new List<int>[v];
			for (int i = 0; i < v; ++i)
				adj[i] = new List<int>();
		}

		// Function to Add an edge into the graph
		public void AddEdge(int v, int w)
		{
			adj[v].Add(w); // Add w to v's list.
		}

        // A function used by DFS
        void DFSUtil(int v, bool[] visited)
        {
            // Mark the current node as visited
            // and print it
            visited[v] = true;
            Console.Write(v + " ");

            // Recur for all the vertices
            // adjacent to this vertex
            foreach (var n in adj[v])
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

		//// A function used by DFS
		//void DFSUtilDisGraph(int v, bool[] visited)
		//{
		//	// Mark the current
		//	// node as visited and print it
		//	visited[v] = true;
		//	Console.Write(v + " ");

		//	// Recur for all the
		//	// vertices adjacent to this
		//	// vertex
		//	foreach (int n in adj[v])
		//	{
		//		if (!visited[n])
		//			DFSUtil(n, visited);
		//	}
		//}

		// The function to do DFS traversal.
		// It uses recursive DFSUtil()
		public void DFS(int v)
        {
            // Mark all the vertices as not visited
            // (set as false by default in c#)
            bool[] visited = new bool[V];

            // Call the recursive helper function
            // to print DFS traversal
            DFSUtil(v, visited);
        }

		// The function to do
		// DFS traversal. It uses recursive
		// DFSUtil()
		public void DFS()
		{
			// Mark all the vertices as not visited(set as
			// false by default in java)
			bool[] visited = new bool[V];

			// Call the recursive helper
			// function to print DFS
			// traversal starting from
			// all vertices one by one
			for (int i = 0; i < V; ++i)
				if (visited[i] == false)
					DFSUtil(i, visited);
		}
	}
}