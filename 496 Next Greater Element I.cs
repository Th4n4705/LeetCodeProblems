public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int, int> dc = new();
        Stack<int> st = new();
        for (int i = 0; i < nums2.Length; i++)
        {
            int n = nums2[i];
            while (st.Count > 0 && st.Peek() < n)
            {
                dc[st.Peek()] = n;
                st.Pop();
            }
            st.Push(n);
        }        
        int[] ans = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            int n = nums1[i];
            if (dc.ContainsKey(n))
                ans[i] = dc[n];
            else
                ans[i] = -1;
        }
        return ans;
    }
}