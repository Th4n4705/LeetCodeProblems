public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) {
        List<int> ans = new();
        int[] arrN = new int[arr.Length];
        arrN[0] = arr[0];
        for (int i = 1; i < arr.Length; i++)
            arrN[i] = arrN[i - 1] ^ arr[i];
        foreach (int[] q in queries)
            ans.Add(q[0] == 0 ? arrN[q[1]] : arrN[q[1]] ^ arrN[q[0] - 1]);
        return ans.ToArray();
    }
}