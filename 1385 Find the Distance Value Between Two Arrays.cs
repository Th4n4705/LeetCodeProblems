public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        int counter = 0;
        foreach (int a in arr1)
        {
            bool check = true;
            foreach (int b in arr2)
                if (a <= b + d && -d + b <= a)
                {
                    check = false;
                    break;
                }
            if (check)
                counter++;
        }
        return counter;
    }
}