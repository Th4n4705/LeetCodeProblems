public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        int[] parent = new int[n];
        for (int i = 0; i < n; i++)
            parent[i] = i;
        foreach (var edge in edges) {
            int parent1 = Checker(parent, edge[0]);
            int parent2 = Checker(parent, edge[1]);
            if (parent1 != parent2)
                parent[parent2] = parent1;
        }
        return Checker(parent, source) == Checker(parent, destination);
    }

    private int Checker(int[] parent, int node)
    {
        if (parent[node] != node)
            parent[node] = Checker(parent, parent[node]);
        return parent[node];
    }
}