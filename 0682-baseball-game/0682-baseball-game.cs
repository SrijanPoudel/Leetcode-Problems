public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> Lyst = new Stack<int>();

        foreach(string item in operations){
            if(item == "C"){
                Lyst.Pop();
            }
            else if(item == "D")
            {
                Lyst.Push(Lyst.Peek()*2);

            }
            else if(item == "+"){
                int top = Lyst.Pop();
                int added = top + Lyst.Peek();
                Lyst.Push(top);
                Lyst.Push(added);
            }
            else{
                Lyst.Push(int.Parse(item));
            }
        }
        return Lyst.Sum();
    }
}
        