

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static  class Class1
    {
        public static  string GetCounts( this string mess)
        {
            int[] sealer = new int[100];
            int s = 0;

            while (s < mess.Length)
            {
                char ch = mess[s];
                switch (ch)
                {
                    case 'a':
                        sealer[0]++;
                        break;
                    case 'A':
                        sealer[0]++;
                        break;
                    case 'e':
                        sealer[1]++;
                        break;
                    case 'E':
                        sealer[1]++;
                        break;
                    case 'i':
                        sealer[2]++;
                        break;
                    case 'I':
                        sealer[2]++;
                        break;
                    case 'o':
                        sealer[3]++;
                        break;
                    case 'O':
                        sealer[3]++;
                        break;
                    case 'u':
                        sealer[4]++;
                        break;
                    case 'U':
                        sealer[0]++;
                        break;
                }
                s++;

            }
            string sum = String.Join("", sealer);
            return sum;



        }
    }
}
