public class Solution {
    public int DistanceTraveled(int mainTank, int additionalTank) {
        int distance = 0;
        while (mainTank > 0 && additionalTank >= 0)
        {
            if (mainTank >= 5 && additionalTank > 0)
            {
                distance += 50;
                mainTank -= 4;
                additionalTank--;
            }
            else if (mainTank > 0)
            {
                distance += 10;
                mainTank--;
            }
        }
        return distance;
    }
}