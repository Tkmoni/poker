using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace poker.rules
{
    class judge
    {
        private void cont(int[] Inhand)
        {
            for (int a = 0; a < 7; a++)
                Inhand[a] = Inhand[a] % 13;
            Quicksort(Inhand);
        }
        private void QuicksortFunc(int[] Numbers)
        {
            int j = 0;
            int i = Numbers.Length-1;
            Console.WriteLine(Numbers.ToString());   
        }
        private void Quicksort(int i, int n, int j)
        {

        }
    }
}
