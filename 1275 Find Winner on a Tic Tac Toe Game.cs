public class Solution {
    public string Tictactoe(int[][] moves) {
        if (moves.Length < 5)
            return "Pending";
        int[][] Combinations = new int[][]
        {
            new[] {0,1,2}, new[] {3,4,5}, new[] {6,7,8},
            new[] {0,4,8}, new[] {2,4,6},
            new[] {0,3,6}, new[] {1,4,7}, new[] {2,5,8} 
        };
        int[] x = new int[9];
        int[] o = new int[9];
        bool turn = true;
        foreach (int[] move in moves)
        {
            int i = move[0] + move[1] * 3;
            if (turn)
                x[i] = 1;
            else
                o[i] = 1;
            turn = !turn;
        }
        foreach (int[] combination in Combinations)
        {
            if (combination.All(i => o[i] == 1))
                return "B";
            if (combination.All(i => x[i] == 1))
                return "A";
        }
        return moves.Length == 9 ? "Draw" : "Pending";
    }
}