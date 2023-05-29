public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        int[] ans = new int[num_people];
        int person = 1;
        int iteration = 1;
        int candiesTo = 0;
        while (candies > 0)
        {
            candiesTo = (iteration - 1) * num_people + person;
            candiesTo = candiesTo >= candies ? candies : candiesTo;
            ans[person - 1] += candiesTo;
            candies -= candiesTo;
            person++;
            if (person > num_people)
            {
                person = 1;
                iteration++;
            }
        }
        return ans;
    }
}