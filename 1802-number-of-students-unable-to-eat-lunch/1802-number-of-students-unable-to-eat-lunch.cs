
public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        Queue<int> queue = new Queue<int>(students);
        int sandwichIndex = 0;
        int count = 0;

        while (queue.Count > 0)
        {
            if (queue.Peek() == sandwiches[sandwichIndex])
            {
                queue.Dequeue();
                sandwichIndex++;
                count = 0; // Reset, because someone ate
            }
            else
            {
                queue.Enqueue(queue.Dequeue());
                count++;

                // If we've cycled through everyone and no one took the sandwich
                if (count == queue.Count)
                {
                    break;
                }
            }
        }

        return queue.Count;
    }
}
