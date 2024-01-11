public class Solution {
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) {
        int bobSum = bobSizes.Sum();
        int aliceSum = aliceSizes.Sum();
        int dif = (bobSum - aliceSum) / 2;
        int[] res = new int[2];
        foreach (int a in aliceSizes)
            if (bobSizes.Contains(a + dif))
            {
                res[0] = a;
                res[1] = a + dif;
                break ;
            }
        return res;
    }
}