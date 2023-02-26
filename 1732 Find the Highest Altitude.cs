public class Solution {
    public int LargestAltitude(int[] gain) {
        int point = 0;
        int Altitude = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            point += gain[i];
            if (point > Altitude)
                Altitude = point;
        }
        return Altitude;
    }
}