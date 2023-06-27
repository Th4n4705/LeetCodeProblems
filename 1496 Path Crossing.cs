public class Solution {
    public bool IsPathCrossing(string path) {
        int xPosition = 0;
        int yPosition = 0;
        HashSet<string> hs = new()
        {
            String.Format("{0},{1}", xPosition, yPosition)
        };
        foreach (char coord in path)
        {
            switch (coord)
            {
                case 'N':
                    yPosition++; break ;
                case 'E':
                    xPosition++; break ;
                case 'S':
                    yPosition--; break ;
                case 'W':
                    xPosition--; break ;
            }
            string current = String.Format("{0},{1}", xPosition, yPosition);
            if (hs.Contains(current))
                return true;
            else 
                hs.Add(current);
        }
        return false;
    }
}