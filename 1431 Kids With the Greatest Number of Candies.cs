public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int[] cc = (int[])candies.Clone();
        int gg = greatestNumber(cc);
        List<bool> ls = new List<bool>();
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= gg)
                ls.Add(true);
            else
                ls.Add(false);
            
        }
        return ls;
    }

    public int greatestNumber (int[] candies)
    {
        Array.Sort(candies);
        return candies[candies.Length - 1];
    }

}