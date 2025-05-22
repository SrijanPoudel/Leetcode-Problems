public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int currentSum = nums[0];
        int maxSum = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1]) {
                currentSum += nums[i];
            } else {
                currentSum = nums[i];
            }
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}
