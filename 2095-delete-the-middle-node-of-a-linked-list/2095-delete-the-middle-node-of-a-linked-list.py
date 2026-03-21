# Definition for singly-linked list.
class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class Solution(object):
    def deleteMiddle(self, head):
        """
        :type head: Optional[ListNode]
        :rtype: Optional[ListNode]
        """
        current = head
        slow = current
        fast = current

        if(current == None or current.next == None):
            return None

        while fast and fast.next:
            prev_slow = slow       # save before moving
            slow = slow.next
            fast = fast.next.next

        prev_slow.next = slow.next
        return head
