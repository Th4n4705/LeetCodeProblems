public class Solution {
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions) {
        List<int[]> robots = new();
        for (int i = 0; i < positions.Length; i++)
            robots.Add(new int[]{i, positions[i], healths[i], directions[i]});
        robots.Sort((a, b) => a[1].CompareTo(b[1]));
        Stack<int[]> st = new();
        foreach (var r in robots)
        {
            if (st.Count == 0 || st.Peek()[3] == 'L' || r[3] == 'R')
            {
                st.Push(r);
                continue;
            }
            if (r[3] == 'L')
            {
                bool isAdded = true;
                while (isAdded && st.Count != 0 && st.Peek()[3] == 'R')
                {
                    int lastHp = st.Peek()[2];
                    if (r[2] > lastHp)
                    {
                        st.Pop();
                        r[2] -= 1;
                    }
                    else if (r[2] < lastHp)
                    {
                        st.Peek()[2] -= 1;
                        isAdded = false;
                    }
                    else
                    {
                        st.Pop();
                        isAdded = false;
                    }
                }
                if (isAdded)
                    st.Push(r);
            }
        }
        List<int[]> ls = new List<int[]>(st);
        ls.Sort((a, b) => a[0].CompareTo(b[0]));
        List<int> ans = new();
        foreach (var r in ls)
            ans.Add(r[2]);
        return ans;
    }
}