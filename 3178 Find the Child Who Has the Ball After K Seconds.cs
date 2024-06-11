public class Solution {
    public int NumberOfChild(int n, int k) {
        int i = 0;
        bool isFound = true;
        while (k > 0)
        {
            if (i == n - 1)
                isFound = false;
            if (i == 0)
                isFound = true;
            if (isFound)
                i++;
            else
                i--;
            k--;
        }
        return i;
    }
}