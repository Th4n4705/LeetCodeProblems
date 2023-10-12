public class Solution {
    public int CountGoodSubstrings(string s) {
        List<string> ls = new();
        for(int i = 0; i < s.Length - 2; i++)
            ls.Add(s.Substring(i, 3));
        int counter = 0;
        foreach (string item in ls)
            if (item[0] != item[1] && item[0] != item[2] && item[1] != item[2])
                counter++;
        return counter;
    }
}