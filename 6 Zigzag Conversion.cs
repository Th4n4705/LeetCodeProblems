public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows <= 1)
            return s;
        string[] sA = new string[numRows];
        int row = 0;
        int witness = -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (row == numRows - 1 || row == 0)
                witness = witness * (-1);
            sA[row] +=s[i];
            if (witness == 1)
                row++;
            else
                row--;
        }
        StringBuilder sb = new();
        for (int i = 0; i < sA.Length; i++)
            sb.Append(sA[i]);
        return sb.ToString();
    }
}