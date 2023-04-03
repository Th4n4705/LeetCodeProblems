public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int boatCounter = 0;
        Array.Sort(people);
        int left = 0;
        int right = people.Length - 1;
        while (left <= right)
        {
            int sum = people[left] + people[right];
            if (sum <= limit)
            {
                boatCounter++;
                left++;
                right--;
            }
            else
            {
                boatCounter++;
                right--;
            }
        }
        return boatCounter;
    }
}