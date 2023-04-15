public class Solution {
    public char FindTheDifference(string s, string t) {
        int sum = 0;
        foreach (var c in s)
            sum -= c;
        foreach (var c in t)
            sum += c;
        return (char) sum;
    }
}