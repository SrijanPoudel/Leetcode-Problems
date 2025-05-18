public class Solution {
    public int Tribonacci(int n) {
        int firstterm = 0,secondterm = 1,thirdterm = 1;
        for(int i=1;i<=n;i++){
            int forthterm = firstterm+secondterm+thirdterm;
            firstterm = secondterm;
            secondterm = thirdterm;
            thirdterm= forthterm;
        }
        return firstterm;
        
    }
}