using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public class Twosum
    {
        public int[] Sum(int[] listt, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < listt.Length; i++)
            {
                for (int j =i+ 1; j < listt.Length; j++)
                {
                    if (listt[i] + listt[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;

                    }
                }
            }
            return result;
        }
    }
}
