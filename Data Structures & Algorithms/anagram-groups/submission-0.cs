public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string item in strs)
        {
            char[] chars = item.ToCharArray();  
            Array.Sort(chars);
            string key = new string(chars);
            if(!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(item);
        }
    return map.Values.ToList();
    }
}
