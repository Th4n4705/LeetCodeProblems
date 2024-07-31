public class Solution {
    public int MinHeightShelves(int[][] books, int shelfWidth) {
        int[] arr = new int[books.Length + 1];
        Array.Fill(arr, int.MaxValue);
        arr[0] = 0;
        for (int i = 1; i <= books.Length; i++)
        {
            int w = 0;
            int h = 0;
            for (int j = i; j > 0; j--)
            {
                w += books[j - 1][0];
                if (w > shelfWidth)
                    break;
                h = Math.Max(h, books[j - 1][1]);
                arr[i] = Math.Min(arr[i], arr[j - 1] + h);
            }
        }
        return arr[books.Length];
    }
}