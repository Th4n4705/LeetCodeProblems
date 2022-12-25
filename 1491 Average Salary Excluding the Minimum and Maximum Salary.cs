public class Solution {
    public double Average(int[] salary) {
        Array.Sort(salary);
        int counter = 0;
        int sum = 0;
        for (int i = 1; i < salary.Length - 1; i++)
        {
            counter++;
            sum += salary[i];
        }
        return (double)(sum) / counter;
    }
}