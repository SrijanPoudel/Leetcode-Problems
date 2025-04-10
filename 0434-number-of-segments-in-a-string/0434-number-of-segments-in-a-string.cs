public class Solution {
    public int CountSegments(string s) {
        string[] words = s.Split(' ');

        int count = 0;

        foreach (string word in words)
        {
            if(word.Length > 0)
            {
                count++;
            }
        }
        return count;
    }
}