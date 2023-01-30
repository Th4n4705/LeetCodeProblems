public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        List<int> ListI = new();
        for (int i = left; i <= right; i++)
        {
            bool Self = false;
            int tmp = i;
            while (tmp > 0)
            {
                int k = tmp % 10;
                if (k != 0 && i % k == 0)
                    Self = true;
                else
                {
                    Self = false;
                    break;
                }
                tmp /= 10;
            }
            if (Self)
                ListI.Add(i);
        }
        return ListI;
    }
}