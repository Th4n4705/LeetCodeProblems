public class Solution {
    public int DistinctAverages(int[] nums) {
        Array.Sort(nums);
        int i = 0;
        int j = nums.Length - 1;
        List<double> ls = new();
        while (i <= j)
        {
            ls.Add((double)(nums[i] + nums[j]) / 2);
            Console.WriteLine(ls[ls.Count - 1]);
            i++;
            j--;
        }
        return ls.Distinct().ToList().Count;
    }
}