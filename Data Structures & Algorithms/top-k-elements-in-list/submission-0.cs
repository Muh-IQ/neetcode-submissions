public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frq = new Dictionary<int, int>();
        for(int i =0; i < nums.Length; i++)
        {
            if(!frq.ContainsKey(nums[i]))
                frq[nums[i]] = 0;
            
            frq[nums[i]] += 1;

        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach (KeyValuePair<int, int> items in frq)
        {
            pq.Enqueue(items.Key, items.Value);
            if(pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        int[] result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;

    }
}
