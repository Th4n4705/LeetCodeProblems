public class Solution {
    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob) {
        int arAlice = DayOfTheYear(arriveAlice);
        int leAlice = DayOfTheYear(leaveAlice);
        int arBob = DayOfTheYear(arriveBob);
        int leBob = DayOfTheYear(leaveBob);
        int maxAr = Math.Max(arAlice, arBob);
        int minLe = Math.Min(leAlice, leBob);
        return minLe - maxAr >= 0 ? minLe - maxAr + 1 : 0;
    }

    int DayOfTheYear(string s)
    {
        Dictionary<int, int> monthsDc = new() { { 1, 31 }, { 2, 28 }, { 3, 31 }, { 4, 30 }, { 5, 31 }, { 6, 30 },
                                             { 7, 31 }, { 8, 31 }, { 9, 30 }, { 10, 31 }, { 11, 30 }, { 12, 31 } };
        int month=Int32.Parse(s.Substring(0,2));
        int days=Int32.Parse(s.Substring(3,2));
        int counter = days;
        for (int i = 1; i < month; i++)
            counter += monthsDc[i];
        return counter;
    }
}