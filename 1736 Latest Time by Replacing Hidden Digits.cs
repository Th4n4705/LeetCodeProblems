public class Solution {
    public string MaximumTime(string time) {
        StringBuilder sb = new();
        if (time[0] == '?')
        {
            if (time[1] == '?')
                sb.Append("23");
            else
                sb.Append(time[1] <= '3' ? "2" : "1").Append(time[1].ToString());
        }
        else
            sb.Append(time[0].ToString()).Append(time[1] == '?' ? (time[0] == '2' ? "3" : "9") : time[1].ToString());
        sb.Append(":").Append(time[3] == '?' ? "5" : time[3].ToString());
        sb.Append(time[4] == '?' ? "9" : time[4].ToString());
        return sb.ToString();
    }
}