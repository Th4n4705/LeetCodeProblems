public class Solution {
    public int DayOfYear(string date) {
        int[] months = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        List<int> dateL = date.Split("-").Select(Int32.Parse)?.ToList();
        if ((dateL[0] % 400 == 0 || (dateL[0] % 100 != 00 && dateL[0] % 4 == 0)) && dateL[1] > 2)
            dateL[2]++;
        for (int i = 1; i < dateL[1]; i++)
            dateL[2] += months[i - 1];
        return dateL[2];
    }
}