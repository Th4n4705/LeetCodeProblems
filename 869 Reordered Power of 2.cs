public class Solution {
    public bool ReorderedPowerOf2(int n)
    {
        string nToString = n.ToString();
        string[] checkerPow2 = CheckerPow2Filler ();
        nToString = Sorter(nToString);
        
        return ResultReturner(checkerPow2, nToString);
    }
    
    //check if the input is founded in the array of cases
    public bool ResultReturner(string[] str, string num)
    {
        int i = 0;
        
        while (i < str.Length)
        {
            if (str[i] == num)
                return true;
            i++;
        }
        
        return false;
    }
    
    //return all cases (10^9)  pow(2,n)
    public string[] CheckerPow2Filler ()
    {
        int i = 1;
        int counter = 0;
        List<string> result = new List<string>();
        
        while (i < 1000000000) // i less than 10^9
        {
            result.Add(i.ToString());
            
            result[counter] = Sorter(result[counter]);// sort the new case string
            
            i *= 2;
            counter++;
        }
        
        return result.ToArray();
    }
    
    // return the str sorted incrementally 
    public string Sorter(string str)
    {
        char[] characters = str.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
}