public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char, int> dict = new ();
        int count = s1.Length;

        for(int i = 0; i < count; i++)
        {
            if(!dict.ContainsKey(s1[i]))
                dict[s1[i]] = 0;

            dict[s1[i]]++;
        }

        int left = 0;
        for(int right = 0; right < s2.Length; right++)
        {
            if(dict.ContainsKey(s2[right]) && dict[s2[right]] > 0)
            {
                dict[s2[right]]--;
                count--;
            }
            else
            {
                if(dict.ContainsKey(s2[left]))
                {
                    dict[s2[left]]++;
                    count++;
                    right--;
                }
                left++;
            }

            if(count == 0) return true;
        }


        return false;
    }


}










/*

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char, int> dict = new ();
        int count = s1.Length;

        for(int i = 0; i < count; i++)
        {
            if(!dict.ContainsKey(s1[i]))
                dict[s1[i]] = 0;

            dict[s1[i]]++;
        }

        int left = 0;
        for(int right = 0; right < s2.Length; right++)
        {
            if(dict.ContainsKey(s2[right]) && dict[s2[right]] > 0)
            {
                dict[s2[right]]--;
                count--;
            }
            else
            {
                while(left < right)
                {
                    if(dict.ContainsKey(s2[right]))
                    {
                        dict[s2[right]]++;
                        count++;
                    }
                    left++;
                }
            }

            if(count == 0) return true;
        }


        return false;
    }


}


*/