public class Solution {
    public int[] ConstructRectangle(int area) {
        int w = (int)Math.Sqrt(area);
        
        while (area % w != 0)
            w--;
        
        int[] a = {area  w, w};
        return a;
    }
}