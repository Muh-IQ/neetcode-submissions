public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int MIN = int.MaxValue;
        int CurrentSum = 0;
        for(int right = 0; right < nums.Length; right++)
        {
           CurrentSum += nums[right];
           while(CurrentSum >= target)
           {
                MIN = Math.Min(MIN, right - left  + 1);
                CurrentSum -= nums[left];
                left++;
           }  
        }
        return MIN == int.MaxValue? 0 : MIN;
    }
}























/*
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int MIN = int.MaxValue;
        int CurrentSum = 0;
        for(int right = 0; right < nums.Length; right++)
        {
           CurrentSum += nums[right];
           while(CurrentSum - nums[left] >= target)
           {
                MIN = Math.Min(MIN, right - left);
                CurrentSum -= nums[left];
                left++;
           }  
        }
        return MIN == int.MaxValue? 0 : MIN;
    }



*/
