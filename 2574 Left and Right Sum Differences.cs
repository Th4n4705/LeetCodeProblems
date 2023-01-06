public class Solution {
    public int[] LeftRigthDifference(int[] nums) {
        int Length = nums.Length;
        List<int> leftL = new();
        List<int> rightL = new();
        for (int i = 0; i < Length; i++)
        {
            if (i == 0)
            {
                leftL.Add(nums[i]);
                rightL.Add(nums[Length - 1]);
            }
            else
            {
                leftL.Add(leftL[i - 1] + nums[i]);
                rightL.Add(rightL[i - 1] + nums[Length - i - 1]);
            }
        }
        List<int> resultList = new();
        int j = Length - 1;
        for (int i = 0; i < Length; i++, j--)
            resultList.Add(Math.Abs(leftL[i] - rightL[j]));
        return resultList.ToArray();
    }
}