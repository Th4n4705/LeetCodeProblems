public class Solution {
    public int FindSpecialInteger(int[] arr) {
        if (arr.Length == 1)
            return arr[0];
        Dictionary<int,int> integerDic = new();
        for (int i = 0; i < arr.Length; i++)
        {
            if (integerDic.ContainsKey(arr[i]))
                integerDic[arr[i]]++;
            else
                integerDic.Add(arr[i],1);
        }

        int maxFound = 0;
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (integerDic[arr[i]] >= counter)
            {
                maxFound = arr[i];
                counter = integerDic[arr[i]];
            }
        }
        return maxFound;
    }
}