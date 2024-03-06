public class Solution {
    public string GenerateTheString(int n) {
        return n % 2 == 0 ? new string('t', n - 1) + 'z' : new string('t', n); 
    }
}