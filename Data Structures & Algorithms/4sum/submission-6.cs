public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        int  n = nums.Length;
        List<List<int>> result = new();
        for (int i = 0; i < n; i++)
        {
            if(i > 0 && nums[i] == nums[i - 1])continue;

            for (int j = i + 1; j < n; j++)
            {
                if(j > i + 1 && nums[j] == nums[j - 1])continue;

                int left = j + 1 , right = n - 1; 
                while(left < right)
                {
                    long sum =(long) nums[i] + nums[left] + nums[right] + nums[j];

                    if(sum < target)
                        left++;
                    else if(sum > target)
                        right--;
                    else
                    {
                        result.Add(new (){
                            nums[i] , nums[left] , nums[right] , nums[j]
                        });

                        left++;right--;
                        while(left < right && nums[left] == nums[left -1])
                            left++;
                        while(left < right && nums[right] == nums[right + 1])
                            right--;

                    }
                }

            }
       
        }
        return result;
    }
}
