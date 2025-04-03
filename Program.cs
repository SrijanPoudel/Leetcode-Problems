using System;

namespace NumRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;

            Removeit remover = new Removeit();
            int k = remover.Solution(nums, val);
            Console.WriteLine(k);
            // Print the modified array
            Console.Write("[");
            for (int i = 0; i < k; i++)
            {
                Console.Write(nums[i]);
                
            }
            Console.WriteLine("]");
        }
    }
}
