public class Solution {
    public string DecodeMessage(string key, string message) {
        int i = 0;
        string result = "";
        key = new string(key.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
        key = new string(key.ToCharArray().Distinct().ToArray());
        Console.WriteLine(key);
        
        while (i < message.Length)
        {
            result += DecodeChar(key, message[i]);
            i++;
        }
        
        return result;
    }
    
    public char DecodeChar(string key, char c)
    {
        int i = 0;
        
        if ( c >= 'a' && c <= 'z')
            while (i < key.Length)
            {
                if (c == key[i])
                    return (char)(97 + i);
                
                i++;
            }
         
        return c;
    }
}