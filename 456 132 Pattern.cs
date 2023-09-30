public class Solution {
    public bool Find132pattern(int[] nums) {
        Stack<int> st = new();
        int third = int.MinValue;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] < third)
                return true;
            while (st.Count > 0 && st.Peek() < nums[i])
                third = st.Pop();
            st.Push(nums[i]);
        }
        return false;
    }
}