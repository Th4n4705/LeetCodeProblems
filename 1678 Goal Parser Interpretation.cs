public class Solution
{
    public string Interpret(string command)
    {
        string result = "";
        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == 'G')
                result += "G";
            else if (command[i] == '(' && command.Length - (i) >= 1 && command[i + 1] == ')')
            {
                result += "o";
                i++;
            }
            else if (command[i] == '(' && command.Length - (i) >= 3 && command[i + 1] == 'a' && command[i + 2] == 'l' && command[i + 3] == ')')
            {
                result += "al";
                i += 3;
            }
        }
        return result;
    }
}