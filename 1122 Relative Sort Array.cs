public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        List<int> ls = new();
        for (int i = 0; i < arr2.Length; i++)
            for (int j = 0; j < arr1.Length; j++)
                if (arr2[i] == arr1[j])
                    ls.Add(arr2[i]);

        List<int> ls2 = new();
        for (int i = 0; i < arr1.Length; i++)
            if (!arr2.Contains(arr1[i]))
                ls2.Add(arr1[i]);
        ls2.Sort();
        ls.AddRange(ls2);
        return ls.ToArray();
    }
}