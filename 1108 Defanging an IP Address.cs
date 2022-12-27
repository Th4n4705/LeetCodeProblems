public class Solution {
    public string DefangIPaddr(string address) {
        StringBuilder sb = new();
        for (int i = 0; i < address.Length; i++)
        {
            if (address[i] != '.')
                sb.Append(address[i]);
            else
                sb.Append("[.]");
        }
        return sb.ToString();
    }
}