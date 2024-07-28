public class Solution {
    public bool CanAliceWin(int[] nums) {
        int single = 0;
        int doubleD = 0;
        foreach (int n in nums)
            if (n < 10)
                single += n;
            else
                doubleD += n;
        return single != doubleD;
    }
}