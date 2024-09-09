public class Solution {
    public string ConvertDateToBinary(string date) {
        string[] s = date.Split('-');
        int y = int.Parse(s[0]);
        int m = int.Parse(s[1]);
        int d = int.Parse(s[2]);
        return $"{Convert.ToString(y, 2)}-{Convert.ToString(m, 2)}-{Convert.ToString(d, 2)}";
    }
}