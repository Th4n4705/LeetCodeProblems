public class Solution {
    public bool IsLongPressedName(string name, string typed) {
        if (typed.Length < name.Length)
            return false;
        int j = 0;
        for (int i = 0; i < typed.Length; i++)
            if (j < name.Length && name[j] == typed[i])
                j++;
            else if (i == 0 || typed[i - 1] != typed[i])
                return false;
        return j == name.Length;
    }
}