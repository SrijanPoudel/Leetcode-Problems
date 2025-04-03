using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Two_Sum
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            Twosum summ = new Twosum();
                Console.WriteLine(string.Join(", ", summ.Sum(new int[] { 2, 7, 11, 15 }, 9)));

            
            
        }
    }
}
