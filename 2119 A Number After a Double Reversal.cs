public class Solution {
    public bool IsSameAfterReversals(int num) {
        if (num == 0)
            return true;

        int newNum = ReverseIt(num);
        
        newNum = ReverseIt(newNum);
        
        return (newNum == num) ? true : false;
    }
    
    public int ReverseIt(int num)
    {                        
        int newNum = num;
        string newStr = "";
        
        while (newNum != 0)
        {
            newStr += (newNum % 10).ToString();
            newNum = newNum / 10;
        }
        
        return Convert.ToInt32(newStr);    
    }
}