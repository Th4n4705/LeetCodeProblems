public class Solution {
    public int NumPrimeArrangements(int n) {
        const int modulo = 1000000007;
        int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };
        int primesLE = primes.Count(x => x <= n);
        long ans = 1;
        for (int i = primesLE; i >= 2; i--)
        {
            ans *= i;
            ans %= modulo;
        }
        for (int i = n - primesLE; i>= 2; i--)
        {
            ans *= i;
            ans %= modulo;
        }
        return (int)ans;
    }
}