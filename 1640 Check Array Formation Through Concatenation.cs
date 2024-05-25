public class Solution {
    public bool CanFormArray(int[] arr, int[][] pieces) {
        for (int i = 0; i < arr.Length;)
        {
            bool detected = false;
            for (int j = 0; j < pieces.Length; j++)
                if (arr[i] == pieces[j][0])
                {
                    detected = true;
                    for (int k = 0; k < pieces[j].Length; k++)
                    {
                        if (arr[i] != pieces[j][k])
                            return false;
                        i++;
                    }
                    break ;
                }
            if (!detected)
                return false;
        }
        return true;
    }
}