using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    public class GFG
    {
        public int subArraySub(int[]ar,int n, int sum)
        {
            int curr_sum, i, j;

            for (i = 0; i < n; i++)
            {
                curr_sum = ar[i];

                for (j = i+1; j <=n; j++)
                {
                    if(curr_sum==sum)
                    {
                        int p = j - 1;
                        Console.Write("Sum found between "
                                 + "indexes " + i + " and " + p);
                        return 1;
                    }

                    if (curr_sum > sum || j == n)
                        break;
                    curr_sum = curr_sum + ar[j];
                }
            }

            Console.Write("No subarray found");
            return 0;
        }
    }
}
