public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        List<int>[] paths = new List<int>[n];
        bool[] visited = new bool[n];
        for (int i = 0; i < n; i++)
            paths[i] = new ();
        foreach (int[] edge in edges)
        {
            int x = edge[0];
            int y = edge[1];
            paths[x].Add(y);
            paths[y].Add(x);
        }
        return Checker(source, destination, paths, visited);
    }

    private bool Checker(int source, int destination, List<int>[] paths, bool[] visited)
    {
        if (source == destination)
            return true;
        if (!visited[source])
        {
            visited[source] = true;
            foreach (int path in paths[source])
                if (Checker(path, destination, paths, visited))
                    return true;
        }
        return false;
    }
}