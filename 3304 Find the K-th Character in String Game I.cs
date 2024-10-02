public class Solution {
    public char KthCharacter(int k) {
        if (k == 1)
            return 'a';
        string alpha = "abcdefghigklmnopqrstuvwxyz";
        int[] arr = new int[1000];
        arr[0] = 0;
        int ind = 1;
        int length = 1;
        while (length < k)
        {
            int counter = length;
            int curr = 0;
            while (counter > 0)
            {
                arr[ind] = arr[curr] + 1;
                if (arr[ind] == 26)
                    arr[ind] = 0;
                curr++;
                ind++;
                counter--;
            }
            length *= 2;
        }
        return alpha[arr[k - 1]];
    }
}