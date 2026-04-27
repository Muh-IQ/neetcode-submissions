public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int MP =0;

        for(int i = 1 ; i < prices.Length; i++)
        {
            min = Math.Min(prices[i] , min);
            int pro = prices[i] - min;

            MP = Math.Max(pro , MP);


        }
        return MP;
    }
}
