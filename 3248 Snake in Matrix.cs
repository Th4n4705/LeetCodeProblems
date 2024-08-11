public class Solution {
    public int FinalPositionOfSnake(int n, IList<string> commands) {
        int r = 0;
        int c = 0;
        foreach (string s in commands)
            switch(s)
            {
                case "UP": 
                    if (r > 0)
                        r--;
                    break ;
                case "RIGHT":
                    if(c < n - 1)
                        c++;
                    break ;
                case "DOWN":
                    if(r < n - 1)
                        r++;
                    break ;
                case "LEFT":
                    if(c > 0)
                        c--;
                    break ;
            }
        return (r * n) + c;
    }
}