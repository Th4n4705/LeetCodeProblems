public class Solution {
    public string RemoveDigit(string number, char digit) {
        if (!number.Contains(digit))
            return number;
        List<string> ls = new();
        for (int i = 0; i < number.Length; i++)
            if (number[i] == digit)
                ls.Add(number.Remove(i, 1));
        return ls.Max();
    }
}