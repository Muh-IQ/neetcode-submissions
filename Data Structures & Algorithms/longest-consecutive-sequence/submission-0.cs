public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int max = 0;

        foreach(int item in set)
        {
            if(!set.Contains(item-1))
            {
                int curr = item + 1;
                int count = 1;
                while(set.Contains(curr))
                {
                    count++;curr++;
                }
                max = Math.Max(max, count);
            }
        }

        return max;
    }


}
