public class Solution {
    public bool JudgeCircle(string moves) {
        int moveRL = 0;  // Right-Left balance
        int moveUD = 0;  // Up-Down balance

        foreach (char letter in moves)
        {
            if (letter == 'U') {
                moveUD++;
            }
            else if (letter == 'D') {
                moveUD--;
            }
            else if (letter == 'R') {
                moveRL++;
            }
            else if (letter == 'L') {
                moveRL--;
            }
        }

        // To return to origin, both directions must cancel out
        return moveRL == 0 && moveUD == 0;
    }
}
