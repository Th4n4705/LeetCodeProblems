public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();
        
        for (int i = 0; i < numRows; i++)
        {
            List<int> row = new List<int>();
            int j;

            for (j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                    row.Add(1);
                else
                    row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
            }
            if (j == 0 && i == 0)
                row.Add(1);
            triangle.Add(row);
                
        }
        
        return (IList<IList<int>>)triangle;
    }
}