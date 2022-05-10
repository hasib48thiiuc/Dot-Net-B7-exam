using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PrimeFinder
    {
        public int[] GetPrimes(int lowerValue, int upperValue)
        {
            int num, i, ctr, j = 0;

            int[] counts = new int[upperValue];

       
            for (num = lowerValue; num <= upperValue; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                {
                    
                   counts[j] = num;
                    j++;
                }
            }
            return counts;
        }
    }
}
    