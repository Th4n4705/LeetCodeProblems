public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int counter = 0;
        foreach (int hour in hours)
            if (hour >= target)
                counter++;
        return counter;
    }
}