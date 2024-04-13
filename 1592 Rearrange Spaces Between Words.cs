public class Solution {
    public string ReorderSpaces(string text) {
        if (text.Length < 2)
            return text;
        List<string> ls = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        int spaceCounter = 0;
        foreach (char c in text)
            if (c == ' ')
                spaceCounter++;
        if (ls.Count == 1)
            return new StringBuilder().Append(ls[0]).Append(new string(' ', spaceCounter)).ToString();
        int k = ls.Count == 1 ? 0 : spaceCounter / (ls.Count - 1);
        int r = ls.Count == 1 ? k : spaceCounter % (ls.Count - 1);
        StringBuilder sb = new StringBuilder()
        .AppendJoin(new string(' ', k), ls)
        .Append(new string(' ', r));
        return sb.ToString();
    }
}