public class Solution {
    public bool JudgeCircle(string moves) {
        int x = 0;
        int y = 0;
        for (int i = 0; i < moves.Length; i++)
            switch(moves[i])
            {
                case 'U' : y += 1;
                    break;
                case 'D' : y -= 1;
                    break;
                case 'L' : x -= 1;
                    break;
                case 'R' : x += 1;
                    break;
            }
        if (x == 0 && y == 0)
            return true;
        return false;
    }
}