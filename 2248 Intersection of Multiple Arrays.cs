public class Solution {
    public IList<int> Intersection(int[][] nums) {
        List<int> res = new();
        Dictionary<int, int> counter  = new();        
        foreach(var num in nums)
            foreach(var n in num)
                if (counter.ContainsKey(n))
                    counter[n]++;
                else
                    counter.Add(n, 1);
        for(int i=0; i < counter.Count; i++)
            if(counter.ElementAt(i).Value == nums.Length)
                res.Add(counter.ElementAt(i).Key);
       res.Sort();
       return res;
    }
}