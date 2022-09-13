public class Solution {
    public bool StrongPasswordCheckerII(string password)
    {
        bool lowCase = false;
        bool uppCase = false;
        bool digit = false;
        bool speChar = false;
        bool notAdj = true;
        
        if (password.Length < 8)
            return false;
        
        int i = 0;
        
        while (i < password.Length)
        {
            if (password[i] <= 'z' && password[i] >= 'a')
                lowCase = true;
            if (password[i] <= 'Z' && password[i] >= 'A')
                uppCase = true;
            if (password[i] <= '9' && password[i] >= '0')
                digit = true;
            if (password[i] == '!' || password[i] == '@' || password[i] == '#' || password[i] == '$' || password[i] == '%' || password[i] == '^' || password[i] == '&' || password[i] == '*' || password[i] == '(' || password[i] == ')' || password[i] == '-' || password[i] == '+')
                speChar = true;
            
            
            if (i + 1 < password.Length && password[i] == password[i + 1])
            {
                notAdj = false;
                break;
            }


            
            i++;
        }
        
        return lowCase && uppCase && digit && speChar && notAdj;
    }
}