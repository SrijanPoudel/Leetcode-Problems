# Definition for singly-linked list.
class ListNode(object):
     def __init__(self, x):
         self.val = x
         self.next = None

class Solution(object):
    def deleteNode(self, node,):
        """
        :type node: ListNode
        :rtype: void Do not return anything, modify node in-place instead.
        """
        prev_node = None
        while node != None and node.next !=None:
            node.val = node.next.val
            prev_node = node
            node= node.next
        
        prev_node.next = None


           