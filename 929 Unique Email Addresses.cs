public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string> Emails = new ();
        foreach (string m in emails)
        {
            string[] splitedEmail = m.Split('@');
            string name = splitedEmail[0];
            string domain = splitedEmail[1];
            if (name.Contains('+'))
                name = name.Split('+')[0];
            name = name.Replace(".", "");
            string email = name + "@" + domain;
            Emails.Add(email);
        }
        return Emails.Count;
    }
}