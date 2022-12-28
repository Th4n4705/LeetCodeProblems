public class Solution {
    public string ReformatDate(string date) {
        List<string> Month = new List<string>(){"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
        StringBuilder sb = new();
        List<string> dateSp = date.Split(" ").ToList();
        sb.Append(dateSp[2]).Append("-").Append(MonthFactoring(Month.IndexOf(dateSp[1]) + 1)).Append("-").Append(DayFactoring(dateSp[0]));
        return sb.ToString();
    }

    public string DayFactoring(string s)
    {
        if (s.Length == 3)
            return "0" + s.Substring(0,1).ToString();
        return s.Substring(0,2).ToString();
    }

    public string MonthFactoring(int n)
    {
        if (n <= 9)
            return "0" + n.ToString();
        return n.ToString();
    }
}