public class Solution {
    public int MinBitFlips(int start, int goal) {
        String startB = Convert.ToString(start, 2);
        string goalB = Convert.ToString(goal, 2);
        int counter = 0;
        if (startB.Length < goalB.Length)
            while (startB.Length != goalB.Length)
                startB = '0' + startB;
        else if (goalB.Length < startB.Length)
            while (goalB.Length != startB.Length)
                goalB = '0' + goalB;
        for (int i = 0; i < goalB.Length; i++)
            if (goalB[i] != startB[i])
                counter++;
        return counter;
    }
}