public class Solution {
    public double CalculateTax(int[][] brackets, int income) {
        int last = 0;
        double tax = 0;
        foreach (var bracket in brackets)
        {
            if (bracket[0] < income)
            {
                tax += (bracket[0] - last) * (double)(bracket[1]) / 100;
                last = bracket[0];
            }
            else
            {
                income -= last;
                tax += (double)(bracket[1] * income) / 100;
                break;
            }
        }
        return tax;
    }
}