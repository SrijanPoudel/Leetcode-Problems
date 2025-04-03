using System;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        
        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }

        
        for (int i = 0; i < m + n; i++)
        {
            for (int j = i + 1; j < m + n; j++)
            {
                if (nums1[i] > nums1[j])
                {
                    int temp = nums1[i];
                    nums1[i] = nums1[j];
                    nums1[j] = temp;
                }
            }
        }

        for (int i = 0; i < m + n; i++)
        {
            Console.Write(nums1[i] + " ");
        }
    }
}
