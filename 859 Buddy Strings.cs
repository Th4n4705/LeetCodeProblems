public class Solution {
    public bool BuddyStrings(string s, string goal) {
        if (s.Length != goal.Length)
            return false;
        if (s == goal)
        {
            HashSet<char> uniqueChars = new HashSet<char>(s);
            return uniqueChars.Count < s.Length;
        }
        List<int> diff = new ();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != goal[i])
                diff.Add(i);
            if (diff.Count > 2)
                return false;
        }
        if (diff.Count != 2)
            return false;
        return s[diff[0]] == goal[diff[1]] && s[diff[1]] == goal[diff[0]];
    }
}