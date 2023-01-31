public class Solution {
    public void DuplicateZeros(int[] arr) {
        List<int> arL = new();
        foreach (var item in arr)
            if (item != 0)
            {
                arL.Add(item);
            }
            else
            {
                arL.Add(item);
                arL.Add(item);
            }
        int[] x = arL.ToArray();
        Array.Copy(x, arr, arr.Length);
    }
}