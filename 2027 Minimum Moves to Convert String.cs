public class Solution {
    public int MinimumMoves(string s) {
        int i = 0;
        int counter = 0;
        char[] sList = s.ToCharArray();
        
        while (i < sList.Length)
        {
            int j = 0;
            bool found = false;
            if (sList[i] == 'X')
            {
                found = true;

                while (j < 3)
                {
                    if (i + j >= sList.Length)
                        break;
                    if (sList[i + j] == 'X')
                        sList[i + j] = 'O';
                    j++;
                }
            }
            
            if (found)
                counter++;
            
            i++;
        }
            
        return counter;
    }
}