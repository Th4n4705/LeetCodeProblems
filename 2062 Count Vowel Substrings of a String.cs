public class Solution {
    public int CountVowelSubstrings(string word) {
        int ans = 0;
        List<char> vowels = new List<char>(){'a', 'e', 'i', 'o', 'u'};
        for (int i = 0; i < word.Length; i++)
        {
            string vow = string.Empty;
            int j = i;
            while (j < word.Length && "aeiou".Contains(word[j]))
            {
                vow += word[j];
                j++;
                bool isValid = true;
                for (int k = 0; k < vowels.Count; k++)
                    if (!(vow.Contains(vowels[k])))
                    {
                        isValid = false;
                        break ;
                    }
                if (isValid)
                    ans++;
            }
        }
        return ans;
    }
}