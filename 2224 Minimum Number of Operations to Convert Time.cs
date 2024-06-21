public class Solution {
    public int ConvertTime(string current, string correct) {
        int counter = 0;
        int[] increment = { 60, 15, 5, 1 };
        int cur = (int.Parse(current[0] + "" + current[1]) * 60) + int.Parse(current[3] + "" + current[4]);
        int cor = (int.Parse(correct[0] + "" + correct[1]) * 60) + int.Parse(correct[3] + "" + correct[4]);
        int session = cor - cur;
        foreach (int n in increment)
        {
            counter += session / n;
            session = session % n;
        }

        return counter;
    }
}