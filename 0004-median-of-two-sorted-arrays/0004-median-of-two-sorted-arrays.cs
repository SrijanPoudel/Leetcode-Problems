public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] ans = Merge(nums1, nums2);
        int n = ans.Length;
        if (n % 2 == 0) {
            return (ans[n / 2] + ans[n / 2 - 1]) / 2.0;
        } else {
            return ans[n / 2];
        }
    }

    public int[] Merge(int[] arr1, int[] arr2) {
        int[] ans = new int[arr1.Length + arr2.Length];
        int p1 = 0, p2 = 0, p3 = 0;

        while (p1 < arr1.Length && p2 < arr2.Length) {
            if (arr1[p1] < arr2[p2]) {
                ans[p3++] = arr1[p1++];
            } else {
                ans[p3++] = arr2[p2++];
            }
        }

        while (p1 < arr1.Length) {
            ans[p3++] = arr1[p1++];
        }

        while (p2 < arr2.Length) {
            ans[p3++] = arr2[p2++];
        }

        return ans;
    }
}
