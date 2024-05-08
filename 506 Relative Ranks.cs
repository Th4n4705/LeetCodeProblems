public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        string[] ans = new string[score.Length];
        Dictionary<int, int> dc = new ();
        for (int i = 0; i < score.Length; i++)
            dc[score[i]] = i;
        Array.Sort(score, (a, b) => b.CompareTo(a));
        for (int i = 0; i < score.Length; i++)
        {
            int rank = i + 1;
            int scoreIndex = dc[score[i]];
            if (rank == 1)
                ans[scoreIndex] = "Gold Medal";
            else if (rank == 2)
                ans[scoreIndex] = "Silver Medal";
            else if (rank == 3)
                ans[scoreIndex] = "Bronze Medal";
            else
                ans[scoreIndex] = rank.ToString();
        }
        return ans;
    }
}
