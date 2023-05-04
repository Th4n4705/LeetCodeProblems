public class Solution {
    public int IsWinner(int[] player1, int[] player2) {
        int sum = 0;
        sum += player1[0];
        sum -= player2[0];
        if (player1.Length > 1)
        {
            sum += player1[0] == 10 ? player1[1] * 2 : player1[1];
            sum -= player2[0] == 10 ? player2[1] * 2 : player2[1];
        }
        for (int i = 2; i < player1.Length; i++)
        {
            if (player1[i - 2] == 10 || player1[i - 1] == 10)
                sum += player1[i] * 2;
            else
                sum += player1[i];

            if (player2[i - 2] == 10 || player2[i - 1] == 10)
                sum -= player2[i] * 2;
            else
                sum -= player2[i];
        }
        if (sum > 0)
            return 1;
        if (sum < 0)
            return 2;
        return 0;
    }
}