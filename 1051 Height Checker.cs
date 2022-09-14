public class Solution {
    public int HeightChecker(int[] heights) {
        int i = 0;
        int counter = 0;
        List<int> list = heights.ToList();
        list.Sort();
        
        while (i < heights.Length)
        {
            if (heights[i] != list[i])
                counter++;
            i++;
        }
        
        return counter;
    }
}