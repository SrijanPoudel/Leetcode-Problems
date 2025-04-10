public class Solution {
    public char FindTheDifference(string s, string t) {
        int sum =0;
        foreach(char letter in t)
            sum +=letter;


        foreach(var letter in s)
            sum-=letter;
        
        return (char)sum;
    }
}