public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res = 0 , left = 0;
        int MF = 0;
        Dictionary<char, int> fq = new();

        for(int right = 0; right < s.Length;right++)
        {
            if(!fq.ContainsKey(s[right]))
                fq.Add(s[right] ,0);
            fq[s[right]]+=1;
            MF = Math.Max(MF , fq[s[right]]);

            int win = right - left + 1;

            if(win - MF > k)
            {
                fq[s[left]]-=1;
                left++;
            }

            res = Math.Max(res , right - left + 1);
        }

        return res;
    }
}


























/*
        int left = 0;
int result = 0;
int maxFreq = 0;
Dictionary<char, int> freq = new();

for (int right = 0; right < s.Length; right++)
{
    freq[s[right]] = freq.GetValueOrDefault(s[right]) + 1;

    maxFreq = Math.Max(maxFreq, freq[s[right]]);

    int windowLength = right - left + 1;

    if (windowLength - maxFreq > k)
    {
        freq[s[left]]--;
        left++;
    }

    result = Math.Max(result, right - left + 1);
}
return result;



*/