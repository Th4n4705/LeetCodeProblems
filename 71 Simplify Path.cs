public class Solution {
    public string SimplifyPath(string path) {
        String[] p = path.Split('/');
        List<string> sList = new();
        foreach (var px in p)
        {
            if (string.IsNullOrEmpty(px) || px == ".")
                continue;
            if (px == "..")
            {
                if (sList.Count > 0)
                    sList.RemoveAt(sList.Count - 1);
        
            }
            else
                sList.Add(px);
        }
        StringBuilder sb = new();
        foreach (var s in sList)
            sb.Append("/" + s);
        if (sb.Length == 0)
            sb.Append("/");
        return sb.ToString();
    }
}