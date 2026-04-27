public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int , int> VIR = new Dictionary<int , int>();
        VIR[nums[0]] = 0;
        for(int i = 1; i < nums.Length;i++)
        {
            int diff = target - nums[i];
            if(VIR.ContainsKey(diff))
                return new int[]{VIR[diff],i};
            else
            {
                VIR[nums[i]] = i;
            }
        }

        return new int[]{-1,-1};
    }
}
