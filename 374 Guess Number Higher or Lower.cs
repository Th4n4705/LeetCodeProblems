/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int right = n, left = 1;
        
        if (guess(n) == 0)
            return n;
        
        right--;
        while (left <= right)
        {
            int mid = Convert.ToInt32(left + Math.Abs((right - left) / 2));
            int result = guess(mid);
            
            if (result >= 0)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return right;
    }
}