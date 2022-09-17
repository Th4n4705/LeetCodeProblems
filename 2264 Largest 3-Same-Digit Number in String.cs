public class Solution {
    public string LargestGoodInteger(string num)
    {
        string result = "";
        int maxNum = -1;
        int i = 0;
        
        while (i < num.Length)
        {
            
            if (ThreeConsucutiveNumber(num, i))
            {
                if (maxNum < 0)
                {
                    maxNum = int.Parse(num[i].ToString());
                    result = num[i].ToString() + num[i].ToString() + num[i].ToString();
                }
                else if (maxNum < int.Parse(num[i].ToString()))
                {
                    maxNum = int.Parse(num[i].ToString());
                    result = num[i].ToString() + num[i].ToString() + num[i].ToString();
                }
            }
            i++;
        }
        return result;
    }
    
    public bool ThreeConsucutiveNumber(string num, int index)
    {
        int i = index;
        
        if (i + 2 < num.Length)
        {
            if (num[i] == num[i + 1] && num[i] == num[i + 2])
                return true;
            return false;
        }
        return false;
    }
}