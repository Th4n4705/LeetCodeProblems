public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int i = 0;
        int counter = 0;
        
        if (flowerbed.Length == 1 && flowerbed[0] == 0 && n <= 1)
            return true;
        else if (flowerbed.Length == 1 && flowerbed[0] == 0 && n > 1)
            return false;
        
        while (i < flowerbed.Length)
        {
            if (i - 1 >= 0 && i + 1 < flowerbed.Length)
            {
                if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    counter++;
                }
            }
            else if (i == 0 && i + 1 < flowerbed.Length && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
            {
                flowerbed[i] = 1;
                counter++;
            }
            else if (i == flowerbed.Length - 1 && flowerbed[i] == 0 && flowerbed[i - 1] == 0)
            {
                flowerbed[i] = 1;
                counter++;
            }
            
            i++;
        }
        
        return counter >= n ? true: false;
    }
}