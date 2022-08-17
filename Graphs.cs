public class Graph<T>
{
    public Graph() { }
    public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges)
    {
        foreach (var vertex in vertices)
            AddVertex(vertex);

        foreach (var edge in edges)
            AddEdge(edge);
    }

    public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

    public void AddVertex(T vertex)
    {
        AdjacencyList[vertex] = new HashSet<T>();
    }

    public void AddEdge(Tuple<T, T> edge)
    {
        if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
        {
            AdjacencyList[edge.Item1].Add(edge.Item2);
            AdjacencyList[edge.Item2].Add(edge.Item1);
        }
    }

    public HashSet<T> GraphBreadthFirstSearch(T start)
    {
        var visited = new HashSet<T>();
        if (!AdjacencyList.ContainsKey(start)) return visited;

        var queue = new Queue<T>();
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            var vertex = queue.Dequeue();
            if (!visited.Contains(vertex))
            {
                visited.Add(vertex);
                foreach (var neighbor in AdjacencyList[vertex])
                {
                    if (!visited.Contains(neighbor)) queue.Enqueue(neighbor);
                }
            }
        }

        return visited;
    }

    public HashSet<T> GraphDepthFirstSearch(T start)
    {
        var visited = new HashSet<T>();
        if (!AdjacencyList.ContainsKey(start)) return visited;

        var stack = new Stack<T>();
        stack.Push(start);

        while (stack.Count > 0)
        {
            var vertex = stack.Pop();
            if (!visited.Contains(vertex))
            {
                visited.Add(vertex);
                var neighbors = AdjacencyList[vertex];
                foreach (var neighbor in neighbors)
                {
                    if (!visited.Contains(neighbor)) stack.Push(neighbor);
                }
            }
        }

        return visited;
    }

    public List<T> GraphDepthFirstSearchRecursive(T start)
    {
        List<T> visited = new List<T>();
        DFS(visited, start);
        return visited;
    }

    private void DFS(List<T> visited, T vertex)
    {
        visited.Add(vertex);
        foreach (var adjacent in AdjacencyList[vertex])
        {
            if (!visited.Contains(adjacent)) DFS(visited, adjacent);
        }
    }

    public List<T> GraphShortestPath(T start, T end)
    {
        var previous = new Dictionary<T, T>();
        var queue = new Queue<T>();
        queue.Enqueue(start);
        if (!AdjacencyList.ContainsKey(start)) return new List<T>();

        while (queue.Count > 0)
        {
            var vertex = queue.Dequeue();
            foreach (var neighbor in AdjacencyList[vertex])
            {
                if (!previous.ContainsKey(neighbor))
                {
                    previous[neighbor] = vertex;
                    queue.Enqueue(neighbor);
                }
            }
        }

        var shortestPath = new List<T>();
        while (!start.Equals(end))
        {
            shortestPath.Add(end);
            end = previous[end];
        }

        shortestPath.Add(end);
        shortestPath.Reverse();
        return shortestPath;
    }

    public List<T> GraphDijkstraShortestPath(T start)
    {
        int[] shortestPath = new int[AdjacencyList.Keys.Count];
        Array.Fill(shortestPath, int.MaxValue);
        int[] visited = new int[AdjacencyList.Keys.Count];

        // TODO: resolve this
        return new List<T>();
    }
}