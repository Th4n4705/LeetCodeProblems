public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int maxCounter = -1;
        
        for (int i = 0; i < s.Length;  i++)
        {
            int counter = 0;
            int closeFoundCounter = -1;
            
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    closeFoundCounter = counter;
                }
                counter++;
            }
            if (closeFoundCounter > maxCounter)
                maxCounter = closeFoundCounter;
        }
        
        return maxCounter;
    }
}