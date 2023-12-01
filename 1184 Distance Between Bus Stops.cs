public class Solution {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        int total = 0;
        int dist = 0;
        for (int i = 0; i < distance.Length; i++)
            total += distance[i];
        while (true)
        {
            int index = start % distance.Length;
            if (index == destination)
                break;
            dist += distance[index];
            start++;
        }
        return Math.Min(total - dist, dist);
    }
}