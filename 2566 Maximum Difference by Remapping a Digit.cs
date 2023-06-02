public class Solution {
    public int MinMaxDifference(int num) {
        int index = 0;
        string s = num.ToString();
        while (index < s.Length - 1 && s[index] == '9')
            index++;
        return int.Parse(s.Replace(s[index], '9')) - int.Parse(s.Replace(s[0], '0'));
    }
}