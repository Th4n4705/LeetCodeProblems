public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int a = 1;
        int b = n - 1;
        while (a < b)
        {
            if (a.ToString().IndexOf("0") < 0 && b.ToString().IndexOf("0") < 0)
                return new int[]{a, b};
            a++;
            b--;
        }
        return new int[]{a, b};
    }
}