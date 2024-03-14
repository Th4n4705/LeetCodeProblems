public class Solution {
    public string BestHand(int[] ranks, char[] suits) {
        Dictionary<char, int> dcSuits = new();
        Dictionary<int, int> dcRanks = new();
        bool isFlush = false;
        bool isKind = false;
        bool isPair = false;
        for (int i = 0; i < ranks.Length; i++)
        {
            dcRanks[ranks[i]] = dcRanks.ContainsKey(ranks[i]) ? dcRanks[ranks[i]] + 1 : 1;
            dcSuits[suits[i]] = dcSuits.ContainsKey(suits[i]) ? dcSuits[suits[i]] + 1 : 1;
            isFlush = isFlush || dcSuits[suits[i]] == 5;
            isKind = isKind || dcRanks[ranks[i]] == 3;
            isPair = isPair || dcRanks[ranks[i]] == 2;
        }
        if (isFlush)
            return "Flush";
        if (isKind)
            return "Three of a Kind";
        if (isPair)
            return "Pair";
        return "High Card";
    }
}