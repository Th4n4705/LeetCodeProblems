public class Solution {
    public int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k) {
        int sum = Math.Min(numOnes, k);
        k -= sum;
        k -= Math.Min(numZeros, k);
        return sum - Math.Min(numNegOnes, k);
    }
}