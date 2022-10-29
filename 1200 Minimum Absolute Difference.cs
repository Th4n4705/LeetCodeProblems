public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        int min = MinimumAbs(arr);
        IList<IList<int>> resultList = new List<IList<int>>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i + 1 < arr.Length && min == arr[i + 1] - arr[i])
            {
                List<int> intervalList = new List<int>();
                intervalList.Add(arr[i]);
                intervalList.Add(arr[i + 1]);
                resultList.Add(intervalList);
            }
        }
        
        return resultList;
            
    }
    
    public int MinimumAbs(int[] arr)
    {
        int min = arr[arr.Length - 1] - arr[0];
        
        for (int i = 0; i < arr.Length; i++)
        {        
            if (i + 1 < arr.Length && min > arr[i + 1] - arr[i])
            {
                min = arr[i + 1] - arr[i];
                if (min == 1)
                    return min;
            }
        }

        return min;
    }
}