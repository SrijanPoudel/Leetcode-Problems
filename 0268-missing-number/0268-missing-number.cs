public class Solution {
    public int MissingNumber(int[] nums) {
        int range = nums.Length;
        int actualsum = (range*(range+1))/2;
        int listsum =0;

        for(int i=0;i<=range-1;i++){
            listsum += nums[i];
        }
        return actualsum-listsum;

    }

}

        