public class Solution {
    public string FindLatestTime(string s) {
        char[] arr = s.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == '?')
                switch (i){
                    case 0 : arr[i] = (arr[1] != '1' && arr[1] != '0' && arr[1] != '?') ? '0' : '1'; break ;
                    case 1 : arr[i] = (arr[0] == '1') ? '1' : '9'; break ;
                    case 3 : arr[i] = '5'; break ;
                    case 4 : arr[i] = '9'; break ;
                }
        return new string(arr);
    }
}