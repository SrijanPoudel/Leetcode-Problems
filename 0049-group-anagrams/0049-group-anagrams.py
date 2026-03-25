from collections import defaultdict
class Solution(object):
    def groupAnagrams(self, strs):
        """
        :type strs: List[str]
        :rtype: List[List[str]]
        """
        anagram_list = defaultdict(list)
        result = []

        for s in strs:
            sorted_s = tuple(sorted(s))
            anagram_list[sorted_s].append(s)

        for value in anagram_list.values():
            result.append(value)
        return result


        