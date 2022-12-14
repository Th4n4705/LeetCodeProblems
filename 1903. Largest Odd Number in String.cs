public class Solution {
    public string LargestOddNumber(string num) {
        int index = -1;
        for (int i = num.Length - 1; i >= 0; i--)
        {
            if (Convert.ToInt32(num[i]) % 2 != 0)
            {
                index = i;
                break;
            }
        }
        
        if (index >= 0 && Convert.ToInt32(num[index]) % 2 != 0)
            return num.Substring(0, index + 1);
        return "";
    }
}