public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char , int> fq = new Dictionary<char , int>();
        foreach(char item in t)
        {
            if(!fq.ContainsKey(item))
                fq.Add(item,0);
            fq[item]+=1;
        }
        
        int left = 0;
        int bestStart = 0;
        int bestLenWin = int.MaxValue;
        int missing = t.Length;
        
        for(int right =0; right < s.Length;right++)
        {
            if(fq.ContainsKey(s[right]))
            {
                if(fq[s[right]] > 0)
                    missing--;
                fq[s[right]]--;
            }
            
            while(missing == 0)
            {
                
                int win = right - left + 1;
                if(win < bestLenWin)
                {
                    bestLenWin = win;
                    bestStart = left;
                }

                if(fq.ContainsKey(s[left]))
                {
                    fq[s[left]]++;
                    if (fq[s[left]] > 0)
                        missing++;
                    
                }
                left++;
            }
        }

        return bestLenWin == int.MaxValue ? ""  : s.Substring(bestStart, bestLenWin);
    }
}
/*

dictionary(letter , count ) => set
miss = t.len

left = 0


for right  =0 to end of s
if s[right] in set and s[right]> 0
    miss --;

if(miss ==0)
loop s[left] not in set
    left++

*/