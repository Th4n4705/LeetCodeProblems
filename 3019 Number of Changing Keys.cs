public class Solution {
    public int CountKeyChanges(string s) {
        int counter = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            int diff = Math.Abs(s[i + 1] - s[i]);
            if (diff != 0 && diff != 32)
                counter++;
        }
        return counter;
    }
}