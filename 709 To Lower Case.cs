public class Solution {
    public string ToLowerCase(string s)
    {
        
        char[] sList = s.ToCharArray();
        
        for (int i = 0; i < sList.Length; i++)
            if (sList[i] <= 90 && sList[i] >= 65)
                sList[i] = Convert.ToChar((int)sList[i] + 32);
                
        string result = new string(sList);//coverting the char array to string
        
        return result;
    }
}