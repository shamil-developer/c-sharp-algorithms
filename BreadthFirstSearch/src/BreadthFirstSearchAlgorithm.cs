namespace BreadthFirstSearch;

public static class BreadthFirstSearchAlgorithm
{
    public static string Search(Dictionary<string, string[]> graph, string startVertex, string targetVertex)
    {
        var queue = new Queue<string>([startVertex]);
        var visited = new HashSet<string>();
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (visited.Contains(current)) { continue; }
            if (current == targetVertex)
            {
                return current;
            }
            visited.Add(current);
            foreach (var item in graph[current]) { queue.Enqueue(item); }
        }

        throw new Exception("Not found");
    }
}
