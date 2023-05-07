public class Solution {
    public int[] LongestObstacleCourseAtEachPosition(int[] ob) {
        List<int> ls = new();
        for (int i = 0; i < ob.Length; i++)
        {
            int n = ob[i];
            if (ls.Count == 0 || ls[ls.Count - 1] <= n)
            {
                ls.Add(n);
                ob[i] = ls.Count;
            }
            else
            {
                int index = FindIndex (ls, n);
                ListUpdate (ls, index, n);
                ob[i] = index + 1;
            }
        }
        return ob;
    }

    private int FindIndex (List<int> ls, int n)
    {
        int index = ls.BinarySearch(n);
        if (index < 0)
            index = ~index;
        else
            index++;
        while (index < ls.Count && ls[index] <= n)
            index++;
        return index;
    }

    private void ListUpdate(List<int> ls, int index, int n)
    {
        if (index == ls.Count)
            ls.Add(n);
        else
            ls[index] = n;
    }
}