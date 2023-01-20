public class Solution {
    public int Maximum69Number (int num) {
        char[] numS = num.ToString().ToCharArray();
        for (int i = 0; i < numS.Length; i++)
        {
            if (numS[i] == '6')
            {
                numS[i] = '9';
                return int.Parse(string.Join("", numS));
            }
        }
        return num;
    }
}