public class Solution {
    public int PivotIndex(int[] nums) {
        int sums =0;
        sums = nums.Sum();
        
        int leftside =0;
        int rightside = sums;

        for(int i =0;i<nums.Length;i++){

            if(leftside == rightside-leftside-nums[i]){
                return i;

            }
            else{
                leftside = leftside + nums[i];
            }

        }
        return -1;
        
    }
} 