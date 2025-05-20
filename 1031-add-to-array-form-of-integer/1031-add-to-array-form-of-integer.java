class Solution {
    public List<Integer> addToArrayForm(int[] num, int k) {
        List<Integer> ans = new ArrayList<>();
        int carrier = 0;
        int p = num.length-1;
        while(p>=0 || k>0){
            int value =0;
            if(p>=0){
                value = num[p];
            }
            int d = k%10;
            int sum = value+d+carrier;
            int digit= sum%10;
            carrier = sum/10;
            ans.add(digit);
            p--;
            k=k/10;
        }
        if(carrier >0){
            ans.add(carrier);
        }
        Collections.reverse(ans);
        return ans;
    }
}