public class OrderedStream {

    string?[] data;
    int ptr;

    public OrderedStream(int n) {
        data = new string[n + 1];
        ptr = 1;
    }
    
    public IList<string> Insert(int idKey, string value) {
        data[idKey] = value;
        List<string> ans = new();
        for (int i = ptr; i < data.Length; i++)
        {
            if (data[i] != null)
                ans.Add(data[i]!);
            else
            {
                ptr = i;
                break;
            }
        }
        return ans;
    }
}

/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */