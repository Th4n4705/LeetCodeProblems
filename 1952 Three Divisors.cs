public class Solution {
    public bool IsThree(int n) {
        
        return IsThreeHelper(n, n, 0);
    }
    
    public bool IsThreeHelper(int n, int diviser, int counter)
    {
        if (diviser == 0 && counter == 3)
            return true;
        else if (diviser == 0 && counter != 3)
            return false;
        
        if (n % diviser == 0)
            return IsThreeHelper(n, diviser - 1, counter + 1);
        else
            return IsThreeHelper(n, diviser - 1, counter);
    }
}