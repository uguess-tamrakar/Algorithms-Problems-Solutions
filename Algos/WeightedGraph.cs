public class WeightedGraph
{
    private static int MinDistanceIdx(bool[] visited, int[] distances)
    {
        int min = int.MaxValue;
        int minIdx = -1;

        for (int v = 0; v < visited.Length; v++)
        {
            if (!visited[v] && distances[v] <= min)
            {
                min = distances[v];
                minIdx = v;
            }
        }

        return minIdx;
    }

    public static int[] Dijkstra(int[,] graph, int src)
    {
        int V = graph.GetLength(0);
        int[] dist = new int[V]; // The output array. dist[i]
                                 // will hold the shortest
                                 // distance from src to i

        // sptSet[i] will true if vertex
        // i is included in shortest path
        // tree or shortest distance from
        // src to i is finalized
        bool[] sptSet = new bool[V];

        // Initialize all distances as
        // INFINITE and stpSet[] as false
        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        // Distance of source vertex
        // from itself is always 0
        dist[src] = 0;

        // Find shortest path for all vertices
        for (int count = 0; count < V - 1; count++)
        {
            // Pick the minimum distance vertex
            // from the set of vertices not yet
            // processed. u is always equal to
            // src in first iteration.
            int u = MinDistanceIdx(sptSet, dist);

            // Mark the picked vertex as processed
            sptSet[u] = true;

            // Update dist value of the adjacent
            // vertices of the picked vertex.
            for (int v = 0; v < V; v++)

                // Update dist[v] only if is not in
                // sptSet, there is an edge from u
                // to v, and total weight of path
                // from src to v through u is smaller
                // than current value of dist[v]
                if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    dist[v] = dist[u] + graph[u, v];
        }

        return dist;
    }

    public static int[] DijkstraShortestPath(int[,] graph, int start)
    {
        int numVertices = graph.GetLength(0);
        int[] shortestPaths = new int[numVertices];
        bool[] visited = new bool[numVertices];

        Array.Fill(visited, false);
        Array.Fill(shortestPaths, int.MaxValue);

        shortestPaths[start] = 0;

        for (int i = 0; i < numVertices; i++)
        {
            int minIdx = MinDistanceIdx(visited, shortestPaths);
            visited[minIdx] = true;

            for (int v = 0; v < numVertices; v++)
            {
                if (!visited[v] && graph[minIdx, v] != 0 && shortestPaths[minIdx] != int.MaxValue && shortestPaths[minIdx] + graph[minIdx, v] < shortestPaths[v])
                {
                    shortestPaths[v] = shortestPaths[minIdx] + graph[minIdx, v];
                }
            }
        }

        return shortestPaths;
    }
}