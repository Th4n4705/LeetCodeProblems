public class Solution {
    public bool IsGood(int[] nums) {
        bool isGood = true;
        Dictionary<int, int> dc = new();
        int max = nums.Max();
        if (max + 1 != nums.Length)
            isGood = !isGood;
        foreach (int num in nums)
        {
            if (dc.ContainsKey(num) && num != max)
                isGood = false;
            else if (dc.ContainsKey(num) && num == max)
                dc[num]++;
            else
                dc[num] = 1;
        }
        if (dc[max] != 2)
            isGood = false;
        return isGood;
    }
}