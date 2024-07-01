public class Solution {
    public int MaxHeightOfTriangle(int red, int blue) {
        return Math.Max(Helper(red, blue), Helper(blue, red));
    }

    int Helper(int a, int b)
    {
        int ans = 0;
        bool isFirst = true;
        int row = 1;
        while (true)
        {
            if (isFirst)
            {
                if (a >= row)
                    a -= row;
                else
                    break;
            }
            else
            {
                if (b >= row)
                    b -= row;
                else
                    break;
            }
            ans++;
            row++;
            isFirst = !isFirst;
        }
        return ans;
    }
}