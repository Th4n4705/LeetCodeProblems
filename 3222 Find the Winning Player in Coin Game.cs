public class Solution {
    public string LosingPlayer(int x, int y) {
        while (true)
        {
            x--;
            y -= 4;
            if (x < 0 || y < 0)
                return "Bob";
            x--;
            y -= 4;
            if (x < 0 || y < 0)
                return "Alice";
        }
    }
}