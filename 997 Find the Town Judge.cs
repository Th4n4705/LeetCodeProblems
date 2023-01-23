public class Solution {
    public int FindJudge(int n, int[][] trust) {
        Dictionary<int,int> Citizens = new();
        if (trust.Length == 1)
            return trust[0][1];
        if (n == 1)
            return 1;
        for (int i = 0; i < trust.Length; i++)
        {
            FillDic(trust[i][0], Citizens, -1);
            FillDic(trust[i][1], Citizens, 1);
        }

        for (int i = 0; i < Citizens.Count; i++)
            if (Citizens.ElementAt(i).Value == n - 1)
                return Citizens.ElementAt(i).Key;
        return -1;
    }

    public void FillDic(int n, Dictionary<int,int> dic, int val)
    {
        if (dic.ContainsKey(n))
        {
            if (val == 1)
                dic[n]++;
            else
                dic[n]--;
        }
        else
            dic.Add(n, val);
    }
}