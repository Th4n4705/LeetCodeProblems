public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        List<int> ls1 = new();
        List<int> ls2 = new();
        int counter = 0;
        for (int i = 0; i < startTime.Length;)
        {
            if (startTime[i] + counter <= endTime[i])
            {
                ls1.Add(startTime[i] + counter);
                counter++;
            }
            if (ls1.Contains(queryTime))
            {
                ls2.Add(i);
                ls1.Clear();
            }
            if (startTime[i] + counter - 1 == endTime[i])
            {
                ls1.Clear();
                counter = 0;
                i++;
            }
        }
        return ls2.Count;
    }
}