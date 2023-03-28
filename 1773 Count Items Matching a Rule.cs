public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int rule;
        if(ruleKey == "type")
            rule = 0;
        else if(ruleKey == "color")
            rule = 1;
        else
            rule = 2;
        int counter = 0;
        foreach (var item in items)
            if (item[rule] == ruleValue)
                counter++;
        return counter;
    }
}