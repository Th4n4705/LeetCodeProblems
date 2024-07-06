public class Solution {
    public int NumberOfAlternatingGroups(int[] colors) {
        int counter = 0;
        for (int i = 0; i + 2 < colors.Length; i++)
            if (colors[i] == colors[i+2] && colors[i] != colors[i + 1])
                counter++;
        if (colors[colors.Length - 1] == colors[1] && colors[colors.Length - 1] != colors[0])
            counter++;
        if (colors[colors.Length - 2] == colors[0] && colors[colors.Length - 2] != colors[colors.Length - 1])
            counter++;
        return counter;
    }
}