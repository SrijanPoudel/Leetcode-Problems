public class Solution {
    public int DominantIndex(int[] nums) {
        int n= nums.Length;
        int max=-1;
        int index =-1;
        for(int i=0;i<=n-1;i++){
            if(nums[i]>=max){
                max=nums[i];
                index = i;
            }
        }
        for(int i=0;i<=n-1;i++){
            if(i!=index && nums[i]*2>max){
                return -1;
            }
        }
        return index;
    }
}