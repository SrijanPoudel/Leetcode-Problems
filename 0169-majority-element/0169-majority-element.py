class Solution(object):
    def majorityElement(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        count = {}
        for n in nums:
            count[n] = count.get(n, 0) + 1
            if count[n] > len(nums) // 2:
                return n

            
                
            

        