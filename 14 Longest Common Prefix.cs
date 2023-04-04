public class Solution {
    public string LongestCommonPrefix(string[] strs) {
   	  string ans = "";
			for (int i = 1; i <= strs[0].Length; i++)
			{
				string k = strs[0].Substring(0, i);
				if (strs.All(x => x.StartsWith(k)))
					ans = k;
				else
					break;
			}
			return ans;
    }
}