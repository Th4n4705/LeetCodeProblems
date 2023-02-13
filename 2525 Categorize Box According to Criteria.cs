public class Solution {
    public string CategorizeBox(int length, int width, int height, int mass) {
        long volume = ((long)length * (long)width * (long)height);
        bool heavy = (mass >= 100);
        bool bulky = (volume >= Math.Pow(10, 9) || (length >= Math.Pow(10, 4) || width >= Math.Pow(10, 4) || height >= Math.Pow(10, 4)));
        if (heavy && bulky)
            return "Both";
        if (heavy)
            return "Heavy";
        if (bulky)
            return "Bulky";
        return "Neither";
    }
}