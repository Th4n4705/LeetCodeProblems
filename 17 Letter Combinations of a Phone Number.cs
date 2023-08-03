public class Solution {
    public IList<string> LetterCombinations(string digits) {
        Dictionary<int,string> dc = new Dictionary<int,string>(){{2,"abc"},{3,"def"},{4,"ghi"},{5,"jkl"},{6,"mno"},{7,"pqrs"},{8,"tuv"},{9,"wxyz"}};
        IList<string> ans = new List<string>();
        if (digits.Length == 0)
            return ans;
        Help (digits, 0, "", ans, dc);
        return ans;
    }

    private void Help (string digits, int i, string current, IList<string> ans, Dictionary<int,string> dc)
    {
        if (i == digits.Length)
        {
            ans.Add(current);
            return;
        }
        string letters = dc[digits[i] - '0'];
        for (int j = 0; j < letters.Length; j++)
            Help (digits, i + 1, current + letters[j], ans, dc);
    }
}