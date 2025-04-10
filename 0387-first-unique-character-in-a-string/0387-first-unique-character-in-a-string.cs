public class Solution {
    public int FirstUniqChar(string s) {

       for(int i = 0; i < s.Length; i++)
       {
        bool isUniq = true;
        
        for(int j = 0; j < s.Length; j++)
        {
            if(i!=j && s[i] == s[j])
            {
                isUniq = false;
                break;
            }
        }

        if(isUniq)
        {
            return i;
        }
       }

       return -1; 
    }
}