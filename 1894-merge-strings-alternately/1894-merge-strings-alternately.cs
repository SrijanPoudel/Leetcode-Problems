public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int p = 0, q = 0;
        string word = "";

        while (p < word1.Length || q < word2.Length)
        {
            if(p < word1.Length)
            {
                word += word1[p];
                p++;
            }

            if(q < word2.Length)
            {
                word += word2[q];
                q++;
            }
        }

        return word;
    }
}