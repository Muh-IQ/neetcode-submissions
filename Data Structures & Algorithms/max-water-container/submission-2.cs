public class Solution {
    public int MaxArea(int[] arr) {
        int left = 0 , right = arr.Length-1;
        int max = 0;
        while(left < right)
        {
            int minHight = Math.Min(arr[left] , arr[right]);
            int space = 0;
            space = right - left ;
            if(arr[left] == minHight)left++;
            else right--;
            max = Math.Max(max , minHight * space);

        }
        return max;

    }
}
