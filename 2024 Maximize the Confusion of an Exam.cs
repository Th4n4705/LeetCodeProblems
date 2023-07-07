public class Solution {
    public int MaxConsecutiveAnswers(string answerKey, int k) {
        return Math.Max(Helper(k, answerKey, 'T'), Helper(k, answerKey, 'F'));
    }

    public int Helper(int max, string s, char symbol)
    {
        int result = 0;
        Queue<int> changed = new();
        for (int l = 0, r = 0; r < s.Length; ++r)
        {
            if (s[r] != symbol)
                changed.Enqueue(r);
            while (changed.Count > max)
                l = changed.Dequeue() + 1;
            result = Math.Max(r - l + 1, result);
        }
        return result;
    }
}