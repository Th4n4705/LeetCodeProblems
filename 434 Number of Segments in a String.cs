public class Solution {
    public int CountSegments(string s) {
        int i = 0;
        int counter = 0;
        
        s = s.Trim();
        
        List<string> sList= s.Split(" ").ToList();

        while (i < sList.Count)
        {
            if (sList[i].Length > 0)
                counter++;
            i++;
        }
        
        return counter;
    }
}