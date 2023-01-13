public class Solution {
    public int FindLucky(int[] arr) {
        int counter = 0;
        int lucky = -1;
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            counter = 0;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    counter++;
                else
                    break;
            }   
            if (arr[i] == counter)
                lucky = counter;
            i += counter - 1;
        }
        return lucky;
    }
}