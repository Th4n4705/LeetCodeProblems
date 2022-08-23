public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        int i = 0;
        double pow;
        while (i <= n / 2)
        {
            pow = MyPow(2, i);
            if (pow == n)
                return true;
            else if (pow > n)
                break;
            i++;
        }
        return false;
    }

    public double MyPow(double x, int n)
    {
        //exceptions
        if (x == 0 && n == 0)
            return 1;
        if (x == 0)
            return 0;
        if (n == -2147483648)
            return 1 / RecursivePowCalculator(x * x, (n / 2) * (-1));

        if (n < 0)
            return 1 / RecursivePowCalculator(x, n * (-1));
        else if (n > 0)
            return RecursivePowCalculator(x, n);
        return 1;
    }

    public double RecursivePowCalculator(double x, int n)
    {
        if (n == 0)
            return 1;

        if (n % 2 == 0)
            return RecursivePowCalculator(x * x, n / 2);
        else
            return x * RecursivePowCalculator(x * x, (n - 1) / 2);
    }
}