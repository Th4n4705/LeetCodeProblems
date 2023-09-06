public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        return RecMinXChar(0, new Dictionary<int, int>(), s, dictionary);
    }

    private int RecMinXChar(int index, Dictionary<int, int> dc, string s, string[] dictionary)
    {
        if (dc.ContainsKey(index))
            return dc[index];
        int ans = s.Length - index;
        for (int i = 0; i < dictionary.Length; i++)
        {
            int indexZ = s.IndexOf(dictionary[i], index);
            if (indexZ != -1)
            {
                int check = (indexZ - index) + RecMinXChar(indexZ + dictionary[i].Length, dc, s, dictionary);
                if (ans > check)
                    ans = check;
            }
        }
        if (!dc.ContainsKey(index))
            dc.Add(index, ans);
        return ans;
    }
}