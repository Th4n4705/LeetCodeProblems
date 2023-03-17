public class Solution {
    public bool EqualFrequency(string word) {
        List<int>  lettersCounter  = new();
        for (int ch = 97; ch <= 122; ch++)
        {
            int counter = 0;            
            for (int i = 0; i < word.Length; i++)
                if (word[i] == (char)ch)
                    counter++;
            if (counter != 0)
                lettersCounter.Add(counter);
        }
        
        int sum = 0;                
        int min = lettersCounter.Min();
        int max = lettersCounter.Max();

        if (lettersCounter.Count == 1 || (lettersCounter.Count == 2 && min == 1))
            return true;
        if (max - min > 1)
            return CheckList(lettersCounter);
        for (int i = 0; i < lettersCounter.Count; i++)
        {
            sum += lettersCounter[i];
            if (lettersCounter[i] != min && lettersCounter[i] != max)
                return false;
        }
        if (sum % lettersCounter.Count == 1 || (min == 1 && (sum -1) % (lettersCounter.Count - 1) == 0) || sum == lettersCounter.Count)
            return true;
        return false;
    }
    
    public bool CheckList(List<int> listT)
    {
        int max = listT.Max();
        int min = listT.Min();
        int counter = 0;
        
        for(int i = 0; i < listT.Count; i++)
        {
            if (max != listT[i])
                counter++;
        }

        if (counter == 1 && listT.Count != 2)
            return true;
        return false;
    }
}
