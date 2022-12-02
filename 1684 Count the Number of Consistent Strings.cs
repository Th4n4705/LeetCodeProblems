public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int counter = 0;
        bool isConsistent;
        for (int i = 0; i < words.Length; i++)
        {
            isConsistent = true;
            for (int j = 0; j<words[i].Length; j++)
            {
                for (int k = 0; k < allowed.Length; k++)
                {
                    if (allowed[k] == words[i][j])
                    {
                        isConsistent = true;
                        break;
                    }
                    else
                        isConsistent = false;
                }
                if (!isConsistent)
                    break;
            }
            if (isConsistent)
                counter++;
        }
        return counter;
    }
}