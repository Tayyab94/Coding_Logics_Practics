using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    public class M_Jump
    {
        public int min_Jump(int[] arr)
        {
            // The number of jumps needed to reach the starting index is 0 
            if (arr.Length<=1)
                return 0;
            // Return -1 if not possible to jump 
            if(arr[0]==0)
            {
                return -1;
            }

            int maxReach = arr[0];
            int step = arr[0];
            int jump = 1;

            int i = 1;
            for ( i = 1; i < arr.Length; i++)
            {
                if(1==arr.Length-1)
                {
                    return jump;
                }

                //Update Max Reach
                maxReach = Math.Max(maxReach, i + arr[i]);
                // we use a step to get
                // to the current index
                step--;

                // If no further steps left
                if(step==0)
                {
                    // We must have to jump
                    jump++;


                    // Check if the current index/position
                    // or lesser index is the maximum reach
                    // point from the previous indexes
                    if (i >= maxReach)
                        return -1;

                    // re-initialize the steps to
                    // the amount of steps to reach
                    // maxReach from position i.
                    step = maxReach - i;
                }
            }

            return -1;
        }
    }
}
