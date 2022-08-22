public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> listFB = new List<string>();
        string valueStr;
        for (int i = 1; i <= n; i++)
        {
            valueStr = "";
            
            if (IsMultiplyerOfThree(i))
                valueStr += "Fizz";
            if (IsMultiplyerOfFive(i))
                valueStr += "Buzz";
            
            
            if (valueStr == "")
                listFB.Add(i.ToString());
            else
                listFB.Add(valueStr);
        }
        
        return listFB;
    }
    
    public bool IsMultiplyerOfThree(int n)
    {
        if (n % 3 == 0)
            return true;
        return false;
    }
    
    public bool IsMultiplyerOfFive(int n)
    {
        if (n % 5 == 0)
            return true;
        return false;
    }
}