public class Solution {
    public bool IsPalindrome(string s) {
        string sanatize = "";
        for(int i = 0; i < s.Length; i++)
        {
            if(Char.IsDigit(s[i]) || Char.IsLetter(s[i]))
                sanatize += Char.ToLower(s[i]);;
        }

        int left = 0 ,right = sanatize.Length-1;
        while(left <= right)
        {
            if(sanatize[left] != sanatize[right])return false;

            left++; right--;
        }

        return true;
    }
}
