public class Solution {
    public int LongestStrChain(string[] words) {
        Dictionary<string, int> dc = new();
        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
        int counter = 0;
        foreach (string word in words)
        {
            dc[word] = 1;
            for (int i = 0; i < word.Length; i++)
            {
                string previouse = word.Remove(i, 1);
                if (dc.ContainsKey(previouse))
                    dc[word] = Math.Max(dc[word], dc[previouse] + 1);
            }
            counter = Math.Max(counter, dc[word]);
        }
        return counter;
    }
}