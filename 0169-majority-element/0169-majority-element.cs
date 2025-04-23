public class Solution {
    public int MajorityElement(int[] nums) {
        int count =0;
        int current=0;

        for(int i =0;i<nums.Length;i++){
             if(count ==0){
                current = nums[i];
            }
            if(current == nums[i]){
                count++;
            }
            else{
                count --;
            }
            if(count ==0){
                current = nums[i];
            }

        }
        return current;
    }
}