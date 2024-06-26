public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] ans = new int[encoded.Length + 1];
        ans[0] = first;
        for (int i = 0; i < encoded.Length; i++)
            ans[i + 1] = encoded[i] ^ ans[i];
        return ans;
    }
}