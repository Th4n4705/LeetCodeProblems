public class Solution {
    public int BulbSwitch(int n) {
        int counter = 0;
        for (int i = 1; i * i <= n; i++)
            counter++;
        return counter;
    }
}