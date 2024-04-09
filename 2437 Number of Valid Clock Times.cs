public class Solution {
    public int CountTime(string time) {
        int counter = 0;
        for (int h = 0; h < 24; h++)
        {
            for (int m = 0; m < 60; m++)
            {
                bool isValid = true;
                string timeF = $"{h:D2}:{m:D2}";
                for (int i = 0; i < 5; i++)
                    if (time[i] != '?' && timeF[i] != time[i])
                    {
                        isValid = false;
                        break;
                    }
                if (isValid)
                    counter++;
            }
        }
        return counter;
    }
}