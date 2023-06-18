public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        int maxUnits = 0;
        Array.Sort(boxTypes, (x,y) => y[1].CompareTo(x[1]));
        for (int i = 0; i < boxTypes.Length; i++)
            if (truckSize > 0)
            {
                maxUnits += truckSize - boxTypes[i][0] < 0 ? truckSize * boxTypes[i][1] : boxTypes[i][0] * boxTypes[i][1];
                truckSize -= boxTypes[i][0];
            }
        return maxUnits;
    }
}