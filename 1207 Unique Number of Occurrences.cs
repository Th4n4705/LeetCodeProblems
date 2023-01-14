public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> dc = new();
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            int counter = 0;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] == arr [j])
                    counter++;
                else
                    break;
            }
            dc.Add(arr[i], counter);
            i += counter - 1;
        }
        foreach (var item1 in dc)
        {
            foreach (var item2 in dc)
            {
                if (item1.Key != item2.Key && item2.Value == item1.Value)
                    return false;
            }
        }
        return true;
    }
}