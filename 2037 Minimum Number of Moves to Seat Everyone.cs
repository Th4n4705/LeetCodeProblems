public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        Array.Sort(seats);
        Array.Sort(students);
        int total = 0;
        for (int i = 0; i < seats.Length; i++)
            total += Math.Abs(seats[i] - students[i]);
        return total;
    }
}