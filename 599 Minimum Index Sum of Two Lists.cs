public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        List<string> common = new();
        int min = Int32.MaxValue;
        for (int i = 0; i < list1.Length; i++)
            for (int j = 0; j < list2.Length; j++)
                if (list1[i] == list2[j] && i + j <= min)
                {
                    if (i + j == min)
                        common.Add(list1[i]);
                    else
                    {
                        common.Clear();
                        common.Add(list1[i]);
                        min = i + j;
                    }
                }
        return common.ToArray();
    }
}