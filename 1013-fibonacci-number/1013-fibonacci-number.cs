public class Solution {
    public int Fib(int n) {
        if(n==0 || n==1){
            return n;
        }
        int firstterm= 0,secondterm =1;
        for(int i=1;i<=n;i++){
            int thirdterm = firstterm+secondterm;
            firstterm = secondterm;
            secondterm = thirdterm;
        }
        return firstterm;
    }
}