public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> UV = new HashSet<int>();
        for(int i =0; i < nums.Length; i++)
        {
            if(UV.Contains(nums[i]))
                return true;
            UV.Add(nums[i]);
        }

        return false;
    }
}