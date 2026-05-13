public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int[] res = new int[nums.Length - k + 1];
        PriorityQueue<(int , int), int> pq = new();
        int left = 0;
        for(int right = 0; right < nums.Length; right++)
        {
            pq.Enqueue((nums[right] , right), nums[right] * -1);

            if(right - left + 1 >= k)
            {
                while(true)
                {
                    (int value , int index) = pq.Peek();
                    if(index >= left)
                    {
                        res[left] = value;
                        break;
                    }
                    else
                        pq.Dequeue();
                }

                left++;
                
            }
        }

        return res;

    }
}
