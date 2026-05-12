public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0 ,right = 0, ws = 0 , we = k - 1;
        int MINDIFF = int.MaxValue;
        int currentDiff = 0;

        for(; right < arr.Length; right++)
        {
            if(right - left + 1 > k)
            {
                if(currentDiff < MINDIFF)
                {
                    ws = left;
                    we = right - 1;
                    MINDIFF = currentDiff;
                }
                currentDiff -= Math.Abs(x - arr[left]);
                left++;
                right--;
            }
            else
                currentDiff += Math.Abs(x - arr[right]);

        }
        if(currentDiff < MINDIFF)
        {
            ws = left;
            we = right - 1;
            MINDIFF = currentDiff;
        }
        List<int> res = new();

        for(int r = ws; r <= we; r++)
            res.Add(arr[r]);
        
        return res;
    }
}