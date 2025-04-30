public class Solution {
    public int FindNumbers(int[] nums) {
        int total =0;

        foreach(int item in nums){
            int count = item.ToString().Length;
            if(count%2==0){
                total++;
            }
        }
        return total;
        
    }
}