public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        string[] op = {"X++","++X","--X","X--"};
        int i = 0;
        int x = 0;
        
        while (i < operations.Length)
        {
            if (operations[i] == op[0] || operations[i] == op[1])
                x++;
            else if (operations[i] == op[2] || operations[i] == op[3])
                x--;
            i++;
        }
        
        return x;
    }
}