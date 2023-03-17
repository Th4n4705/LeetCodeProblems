public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if (arr.Length < 3)
            return false;
        int d = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0 && arr[i] <= arr[i - 1])
            {
                if (i - 1 == 0 || arr[i] == arr[i - 1])
                    return false;
                d = i;
                break;
            }
        }

        for (int i = d + 1; i < arr.Length; i++)
        {
            if (arr[i] >= arr[i - 1])
                return false;
        }
        return true;
    }
}