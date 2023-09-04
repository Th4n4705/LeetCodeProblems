public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int counter = 0;
        for (int i = low; i <= high; i++)
            if (IsSymmetric(i))
                counter++;
        return counter;
    }

    private bool IsSymmetric(int x)
    {
        if (x.ToString().Length % 2 != 0)
            return false;
        if (x < 100 && x % 11 == 0)
            return true;
        List<int> ls = new();
        while (x > 0)
        {
            ls.Add(x % 10);
            x /= 10;
        }
        int sum = 0;
        for (int i = 0; i < ls.Count / 2; i++)
            sum += ls[i] - ls[ls.Count - i - 1];
        return sum == 0;
    }
}