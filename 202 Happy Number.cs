public class Solution {
    public bool IsHappy(int n) {
        int slow = n;
        int fast = n;
        do{
            slow = ProcessPath(slow);
            fast = ProcessPath(fast);
            fast = ProcessPath(fast);
            if (fast == 1)
                return true;
        }while (slow != fast);
        return slow == 1;
    }

    public int ProcessPath(int q)
    {
        if (q == 1)
            return 1;
        int sum = 0;
        while (q > 0)
        {
            int a = q % 10;
            q /= 10;
            sum += (a * a);
        }
        return sum;
    }
}