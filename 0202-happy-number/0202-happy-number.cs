public class Solution {
    public bool IsHappy(int n) {

        HashSet<int> set = new HashSet<int>();

        while(true)
        {
            if(n==1){
                return true;
            }
            if(set.Contains(n)){
                return false;
            }
            set.Add(n);
            n= Calculation( n);

        } 
    }

    private int Calculation(int n){
        int sum =0;

        while(n>0){
            int digit = n%10;
            sum = sum +digit*digit;
            n = n/10;
        }
        return sum;
        
    }
}