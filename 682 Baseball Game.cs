public class Solution {
    public int CalPoints(string[] operations) {
        List<int> rec = new();
        for (int i = 0; i < operations.Length; i++)
            if (int.TryParse(operations[i], out int value))
                rec.Add(value);
            else if (operations[i] == "D")
                rec.Add(rec[rec.Count - 1] * 2);
            else if (operations[i] == "C")
                rec.RemoveAt(rec.Count - 1);
            else if (operations[i] == "+")
                rec.Add(rec[rec.Count - 1] + rec[rec.Count - 2]);
        return rec.Sum();
    }
}