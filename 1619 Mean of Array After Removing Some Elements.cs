public class Solution {
    public double TrimMean(int[] arr) {
        int counter = 0;
        int sum = 0;
        Array.Sort(arr);
        int perc = (int)(arr.Length * 0.05);
        for (int i = perc; i < arr.Length - perc; i++)
        {
            counter++;
            sum += arr[i];
        }
        return (double)(sum) / counter;
    }
}