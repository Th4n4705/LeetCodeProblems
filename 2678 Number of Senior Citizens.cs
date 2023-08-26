public class Solution {
    public int CountSeniors(string[] details) {
        int counter = 0;
        foreach (string d in details)
            if (Convert.ToInt32(d.Substring(11, 2)) > 60)
                counter++;
        return counter;
    }
}