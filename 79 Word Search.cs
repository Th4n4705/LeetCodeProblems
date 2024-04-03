public class Solution {
    public bool Exist(char[][] board, string word) {
        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[0].Length; j++)
                if (BackTrackIt(board, word, i, j, 0))
                    return true;
        return false;
    }

    bool BackTrackIt(char[][] board, string word, int i, int j, int k)
    {
        if (k >= word.Length)
            return true;
        if (i < 0 || j < 0 || i >= board.Length ||  j >= board[0].Length || board[i][j] != word[k])
            return false;
        char tmp = board[i][j];
        board[i][j] = '+';
        bool ans = BackTrackIt(board, word, i + 1, j, k + 1) || 
        BackTrackIt(board, word, i, j + 1, k + 1) || 
        BackTrackIt(board, word, i - 1, j, k + 1) || 
        BackTrackIt(board, word, i, j - 1, k + 1);
        board[i][j] = tmp;
        return ans;
    }
}