public class Solution {
    public int MinimumSum(int num) {
        List<int> ls = new();
        while (num > 0)
        {
            ls.Add(num % 10);
            num /= 10;
        }
        ls.Sort();
        return ((ls.First() * 10) + ls.Last()) + ((ls[1] * 10) + ls[2]);
    }
}