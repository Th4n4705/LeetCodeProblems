public class Solution {
    public int DistributeCandies(int[] candyType) {
        int i = 0;
        int diffCounter = 1;
        Array.Sort(candyType);
        
        while (i < candyType.Length)
        {
            if (i + 1 < candyType.Length && candyType[i] != candyType[i + 1])
            {
                diffCounter++;
            }
            i++;
        }
        
        if (diffCounter >= candyType.Length / 2)
            return candyType.Length / 2;
        return diffCounter;
    }
}