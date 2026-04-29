public class Solution {
    public int FindMin(int[] nums) {
       int Min = nums[0];
       int left =0;
       int right = nums.Length-1;

       while(left <= right)
       {
            if(nums[left] < nums[right])
            {
                Min = Math.Min(Min , nums[left]);
                break;
            }
            int mid = (right + left) / 2;

            Min = Math.Min(Min , nums[mid]);

            if(nums[mid] >= nums[left])
                left = mid + 1;
            else
                right = mid - 1;

       }

       return Min;

}
}