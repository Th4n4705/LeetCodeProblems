public class Solution {
    public bool IsValid(string word) {
        if (word.Length < 3)
            return false;
        int ans = 0;
        foreach (char c in word)
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                ans |= IsItVowel(c) ? 1 : 2;
            else if (!char.IsDigit(c))
                return false;
        return ans == 3;
    }

    bool IsItVowel (char c)
    {
        List<char> vowels = new List<char> {'a' , 'e' , 'i' , 'o' , 'u' , 'A' , 'E' , 'I' , 'O' , 'U'};
        return vowels.IndexOf(c) != -1;
    }
}