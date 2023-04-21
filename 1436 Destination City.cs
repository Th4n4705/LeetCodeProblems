public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        Dictionary<string, string> dc = new ();
        foreach (var path in paths)
            dc[path[0]] = path[1];
        string station = paths[0][0];
        while (dc.ContainsKey(station))
            station = dc[station];
        return station;
    }
}