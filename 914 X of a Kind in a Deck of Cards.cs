public class Solution {
    public bool HasGroupsSizeX(int[] deck) {
        if (deck.Length == 1 && deck[0] == 1)
            return false;
        Dictionary<int, int> dc = new();
        for (int i = 0; i < deck.Length; i++)
            if (dc.ContainsKey(deck[i]))
                dc[deck[i]]++;
            else
                dc.Add(deck[i], 1);
        for (int i = 2; i < 20; i++)
            if (dc.Values.All(v => v % i == 0))
                return true;
        return false;
    }
}