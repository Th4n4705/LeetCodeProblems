public class Solution {
    public int NumberOfMatches(int n) {
        if (n == 1)
            return 0;
        
        int match = 0;
        int counter = 0;
        while (match != 1)
        {
            int rest = 0;
            if (n % 2 != 0)
            {
                match = n / 2;
                rest = 1;
            }
            else
                match = n / 2;
            counter += match;
            n  = match + rest;
            match = n;
        }
        return counter;
    }
}