public class Solution {
    public int CountTriples(int n) {
        int counter = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = i + 1; j <= n; j++)
            {
                for (int k = j + 1; k <= n; k++)
                {
                    if (IsSquare(i, j, k))
                        counter += 2;
                }   
            }
        }
        return counter;
    }
    
    public bool IsSquare(int a, int b, int c)
    {
        return (a * a) + (b * b) == (c * c);
    }
}
