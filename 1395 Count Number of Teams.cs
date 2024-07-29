public class Solution {
    public int NumTeams(int[] rating) {
        int counter = 0;
        for (int i = 0; i < rating.Length; i++)
        {
            int leftBig = 0;
            int rightBig = 0;
            int leftSmall = 0;
            int rightSmall = 0;
            for (int j = 0; j < i; j++)
                if (rating[j] < rating[i])
                    leftSmall++;
                else if (rating[j] > rating[i])
                    leftBig++;
            for (int k = i + 1; k < rating.Length; k++)
                if (rating[k] < rating[i])
                    rightSmall++;
                else if (rating[k] > rating[i])
                    rightBig++;
            counter += leftSmall * rightBig;
            counter += leftBig * rightSmall;
        }
        return counter;
    }
}