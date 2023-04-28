public class Solution {
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime) {
        int interval = delayedTime + arrivalTime;
        switch (interval / 24)
        {
            default: if (interval == 24)
                            return 0;
                    return interval;
            case 1:
                interval = interval - 24;
                if (interval == 24)
                    return 0;
                return interval;
        }
    }
}