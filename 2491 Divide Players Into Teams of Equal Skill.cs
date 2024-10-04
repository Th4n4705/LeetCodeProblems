public class Solution {
    public long DividePlayers(int[] skill) {
        Array.Sort(skill);
        int sum = skill[0] + skill[skill.Length - 1];
        long chemistry = 0;
        for (int i = 0; i < skill.Length / 2; i++)
        {
            if (skill[i] + skill[skill.Length - i - 1] != sum)
                return -1;
            chemistry += (long)skill[i] * skill[skill.Length - i - 1];
        }
        return chemistry;
    }
}