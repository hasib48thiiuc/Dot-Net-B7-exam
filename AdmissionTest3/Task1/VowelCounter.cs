using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class VowelCounter
    {
        public string GetCounts(string mess)
        {
            int[] sealer = new int[100] ;
            int i = 0;
            while(i < mess.Length)
            {
                if (mess[i] == 'a' || mess[i] == 'A')
                {
                    sealer[0]++;
                }
                else if (mess[i] == 'e' || mess[i] == 'E')
                {
                    sealer[1]++;
                }
                else if (mess[i] == 'i' || mess[i] == 'I')
                {
                    sealer[2]++;
                }
                else if (mess[i] == 'o' || mess[i] == 'O')
                {
                    sealer[3]++;
                }
                else if (mess[i] == 'u' || mess[i] == 'U')
                {
                    sealer[4]++;
                }
                i++;
            }
            string summ = String.Join("", sealer);
            return summ;
        }
    }
}