public class Solution {
    public bool HaveConflict(string[] event1, string[] event2) {
        double begin1 = HourToDouble(event1[0]);
        double end1 = HourToDouble(event1[1]);
        double begin2 = HourToDouble(event2[0]);
        double end2 = HourToDouble(event2[1]);
        
        if ((begin1 <= end2 && begin1 >= begin2) || (begin2 <= end1 && begin2 >= begin1) || (end1 <= end2 && end1 >= begin2) || (end2 <= end1 && end2 >= begin1))
            return true;
        return false;
    }
    
    public double HourToDouble(string s)
    {
        return ((Double.Parse(s[0].ToString()) * 10) + Double.Parse(s[1].ToString())) + ((Double.Parse(s[3].ToString()) * 10) + Double.Parse(s[4].ToString())) / 60;
    }
}