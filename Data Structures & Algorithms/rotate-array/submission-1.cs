public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        nums = reverese(nums , 0 , nums.Length - 1);
        nums = reverese(nums , 0 , k - 1);
        nums = reverese(nums , k , nums.Length - 1);
    }

    private int[] reverese(int[] nums,int start, int end)
    {
        while(start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;end--;
        }

        return nums;
    }
}