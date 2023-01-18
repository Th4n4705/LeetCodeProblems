public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i + 2 < arr.Length && arr[i] % 2 != 0 && arr[i + 1] % 2 != 0 && arr[i + 2] % 2 != 0)
                return true;
        }
        return false;
    }
}