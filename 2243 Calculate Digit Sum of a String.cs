public class Solution {
    public string DigitSum(string s, int k) {
        if (s.Length <= k)
            return s;
     
        int i = 0;
        string newStr = "";
        int counter = 1;
        int res = 0;
        List<char> nums = new List<char>();
        nums.AddRange(s);
        while (i < nums.Count)
        {
            res += Convert.ToInt32(new string(nums[i], 1));
            if (counter == k)
            {
                newStr += res.ToString();
                res = 0;
                counter = 0;
            }
            i++;
            counter++;
        }
        
        if (counter != 1)
            newStr += res.ToString();
        
        return DigitSum(newStr,k);
    }
}