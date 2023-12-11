public class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        int counter = 0;
        int decreasing = 0;
        for (int i = 0; i < batteryPercentages.Length; i++)
            if (batteryPercentages[i] - decreasing > 0)
            {
                counter++;
                decreasing++;
            }
        return counter;
    }
}