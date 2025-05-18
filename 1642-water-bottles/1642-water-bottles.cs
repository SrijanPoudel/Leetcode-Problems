public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int count =numBottles;

        while(numBottles>=numExchange){
            int newfull = numBottles/numExchange;
            count+=newfull;
            numBottles = newfull+(numBottles%numExchange);
        }
        return count;
    }
}