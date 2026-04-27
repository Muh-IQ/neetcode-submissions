public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char , int> CR = new Dictionary<char , int>();

        for(int i = 0; i < s.Length;i++)
        {
            if(CR.ContainsKey(s[i]))
            {
                CR[s[i]] += 1;
            }
            else
                CR[s[i]] = 1;
        }

        for(int i = 0; i < t.Length;i++)
        {
            if(CR.ContainsKey(t[i]) && CR[t[i]] == 0)
            {
                return false;
            }
            else if(CR.ContainsKey(t[i])){
                CR[t[i]] -= 1;
            }
            else{
                return false;
            }
        }

        return true;



    }
}
