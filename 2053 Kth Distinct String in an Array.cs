public class Solution {
    public string KthDistinct(string[] arr, int k) {
        List<string> listSolo = new();
        for (int i = 0; i < arr.Length; i++)
        {
            int counter = 0;
            for (int j = 0 ; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    counter++;
            }
            if (counter == 1)
                listSolo.Add(arr[i]);
            if (listSolo.Count == k)
                break;
        }

        if (listSolo.Count == k)
            return listSolo[k - 1];
        return "";
    }
}