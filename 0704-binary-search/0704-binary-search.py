class Solution(object):
    def search(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        n =0
        while n<= len(nums)-1:
            if nums[n] == target:
                return n
            else:
                n +=1
        return -1
        