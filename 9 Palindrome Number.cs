public class Solution
{
    public bool IsPalindrome(int x)
    {
        string num = x.ToString();
        int i = 0;
        int j = num.Length - 1;
        while (i < j)
        {
            if (num[i] != num[j])
                return false;
            i++;
            j--;
        }
        return (num[i] == num[j]);
    }
}

//another solution
/*
public class Solution {
    public bool IsPalindrome(int x) {
        string num = x.ToString();
        string numReversed = ReverseString(num);
            
        if (num == numReversed)
            return true;
        return false;
    }
    
    public string ReverseString (string str)
    {
        string reversed = "";
        int strLength = str.Length - 1;
        
        while (strLength >= 0)
        {
            reversed += str[strLength];
            strLength--;
        }
        return reversed;
    }
}
*/