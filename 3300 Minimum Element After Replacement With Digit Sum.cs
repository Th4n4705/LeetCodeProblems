public class Solution {
    public int MinElement(int[] nums) {
        int min = int.MaxValue;
        foreach (int num in nums){
            string s = num.ToString();
            int sum = 0;
            foreach (char c in s){
                sum += (c - '0');
            }
            min = Math.Min(min, sum);
        }
        return min;
    }
}