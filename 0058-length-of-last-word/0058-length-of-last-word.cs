public class Solution {
    public int LengthOfLastWord(string s) {
        int lastword = s.Length-1;
        int output=0;

        while(s[lastword]==' '){
            lastword--;
        }
        while(lastword>=0 && s[lastword]!=' '){
            output++;
            lastword--;
        }
        return output;

        }
    }
