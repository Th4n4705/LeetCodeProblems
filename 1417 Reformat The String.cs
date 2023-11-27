public class Solution {
    public string Reformat(string s) {
        Stack<char> letters = new();
        Stack<char> nums = new();
        for (int i = 0; i < s.Length; i++)
            if (Char.IsDigit(s[i]))
                nums.Push(s[i]);
            else
                letters.Push(s[i]);
        if(Math.Abs(letters.Count - nums.Count) > 1) 
            return String.Empty;
        bool isLetter = letters.Count > nums.Count;
        StringBuilder sb = new();
        for (int i = 0; i < s.Length; i++)
        {
            sb.Append (isLetter ? letters.Pop() : nums.Pop());
            isLetter = !isLetter;
        }
        return sb.ToString();
    }
}