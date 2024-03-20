public class Solution {
    public string ReformatNumber(string number) {
        StringBuilder sb = new(number.Length);
        int counter = 0;
        foreach (char c in number)
        {
            if (char.IsDigit(c))
            {
                sb.Append(c);
                ++counter;
                if (counter == 3)
                {
                    sb.Append('-');
                    counter = 0;
                }
            }
        }
        if (counter == 0)
            --sb.Length;
        else if (counter == 1)
        {
            sb[^2] = sb[^3];
            sb[^3] = '-';
        }
        return sb.ToString();
    }
}