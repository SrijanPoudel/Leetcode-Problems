public class Solution {
    public int MaxNumberOfBalloons(string text)
    {
        int a = 0;
        int b = 0;
        int l = 0;
        int o = 0;
        int n = 0;

        foreach (char c in text)
        {
            if (c == 'a') {
                a++;
            }
            else if (c == 'b') {
                b++;
            }
            else if (c == 'l') {
                l++;
            }
            else if (c == 'o') {
                o++;
            }
            else if (c == 'n') {
                n++;
            }
        }

        // l and o are needed twice in the word "balloon"
        l = l / 2;
        o = o / 2;

        int min1 = Math.Min(b, a);
        int min2 = Math.Min(l, o);
        int min3 = Math.Min(min1, min2);
        int final = Math.Min(min3, n);

        return final;
    }
}
