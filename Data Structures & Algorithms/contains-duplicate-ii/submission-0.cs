public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int left = 0;
        HashSet<int> win = new();
        for(int right = 0; right < nums.Length; right++)
        {
            if(win.Contains(nums[right]))
                return true;
            if(right - left >= k)
            {
                win.Remove(nums[left]);
                left++;
            }
            win.Add(nums[right]);
        }

        return false;
    }
}