public class Solution {
    public int PassThePillow(int n, int time) {
        int rounds = time / (n - 1);
        int index = time % (n - 1);
        return rounds % 2 == 0 ? index + 1 : n - index;
    }
}