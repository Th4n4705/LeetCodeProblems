public class Solution {
    public int TitleToNumber(string columnTitle) {
        int result = 0;
        foreach (var ch in columnTitle)
        {
            int index = ch - 'A' + 1;
            result = result * 26 + index;
        }
        return result;

    }
}