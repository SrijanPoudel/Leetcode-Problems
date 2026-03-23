# Definition for singly-linked list.
class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
import random
class Solution(object):

    def __init__(self, head):
        """
        :type head: Optional[ListNode]
        """
        temp = head
        self.arr = []

        while(temp):
            self.arr.append(temp.val)
            temp = temp.next

    def getRandom(self):
        """
        :rtype: int
        """
        n = len(self.arr)
        random_index= random.randint(0,n-1) % n
        
        return self.arr[random_index]
        
        


# Your Solution object will be instantiated and called as such:
# obj = Solution(head)
# param_1 = obj.getRandom()