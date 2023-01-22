public class Solution {
    public int AlternateDigitSum(int n) {
        string nString = n.ToString();
        int Sum = 0;
        for (int i = 0; i < nString.Length; i++)
        {
            if (i % 2 == 0)
                Sum = Sum + Convert.ToInt32(Char.GetNumericValue(nString[i]));
            else if (i % 2 != 0)
                Sum = Sum - Convert.ToInt32(Char.GetNumericValue(nString[i]));
        }
        return Sum;
    }
}