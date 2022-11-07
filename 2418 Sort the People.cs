public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        for (int i = 0; i < names.Length; i++)
        {
            for (int j = i + 1; j < names.Length; j++)
                if (heights[i] < heights[j])
                {
                    int  tmpHeights = heights[j];
                    heights[j] = heights[i];
                    heights[i] = tmpHeights;
                    string tmpName = names[j];
                    names[j] = names[i];
                    names[i] = tmpName;
                }
        }
        
        return names;
    }
}