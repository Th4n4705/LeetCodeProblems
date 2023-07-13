public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<List<int>> ls = new();
        bool[] visited = new bool[numCourses];
        bool[] recursion = new bool[numCourses];
        for (int i = 0; i < numCourses; i++)
            ls.Add(new List<int>());
        foreach (int[] p in prerequisites)
        {
            int course = p[0];
            int pCourse = p[1];
            ls[course].Add(pCourse);
        }
        for (int i = 0; i < numCourses; i++)
            if (HasCycle(i, ls, visited, recursion))
                return false;
        return true;
    }

    bool HasCycle(int c, List<List<int>> ls, bool[] visited, bool[] recursion)
    {
        visited[c] = true;
        recursion[c] = true;
        foreach (int p in ls[c])
        {
            if (recursion[p])
                return true;
            if (!visited[p] && HasCycle(p, ls, visited, recursion))
                return true;
        }
        recursion[c] = false;
        return false;
    }
}