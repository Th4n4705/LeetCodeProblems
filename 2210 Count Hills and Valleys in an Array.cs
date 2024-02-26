public class Solution {
    public int CountHillValley(int[] nums) {
        List<int> ls = nums.ToList();
        int counter = 0;
        for (int i = 1; i < ls.Count; i++)
            if (ls[i] == ls[i - 1])
            {
                ls.RemoveAt(i - 1);
                i--;
            }
        for (int i = 1; i < ls.Count - 1; i++)
            if ((ls[i] > ls[i - 1] && ls[i] > ls[i + 1]) || (ls[i] < ls[i - 1] && ls[i] < ls[i + 1]))
                counter++;
        return counter;
    }
}