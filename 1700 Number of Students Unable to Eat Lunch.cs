public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> q = new (students);
        int sndIndex = 0;
        int qIndex = -1;
        int student = -1;
        int ans = -1;
        while (q.Count != ans)
        {
            for (qIndex = 0, ans = q.Count; qIndex < ans; qIndex++)
                if (sandwiches[sndIndex] == (student = q.Dequeue()))
                    sndIndex++;
                else
                    q.Enqueue(student);
        }
        return ans;
    }
}