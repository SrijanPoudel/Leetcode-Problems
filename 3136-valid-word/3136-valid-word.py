class Solution(object):
    def isValid(self, word):
        """
        :type word: str
        :rtype: bool
        """
        vowel = set("aeiouAEIOU")
        has_vowel = False
        has_consonent = False
        if len(word)>=3:
            for ch in word:
                if not ch.isalnum():
                    return False
                if ch.isalpha():
                    if ch in vowel:
                        has_vowel = True
                    else:
                        has_consonent = True
        return has_vowel and has_consonent

