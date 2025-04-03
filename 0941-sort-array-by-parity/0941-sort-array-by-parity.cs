public class Solution {
    public int[] SortArrayByParity(int[] nums) {
    List<int> result = new List<int>();

    // Add evens first
    foreach (int num in nums) {
        if (num % 2 == 0) {
            result.Add(num);
        }
    }

    // Add odds after
    foreach (int num in nums) {
        if (num % 2 != 0) {
            result.Add(num);
        }
    }

    return result.ToArray();
    }
}