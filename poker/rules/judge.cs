using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace poker.rules
{
    class judge
    {
        private int[] sortnumber;

        public judge(int[] number)
        {
            sortnumber = number;

        }

        private void cont(int[] Inhand)
        {
            for (int a = 0; a < 7; a++)
                Inhand[a] = Inhand[a] % 13;
            Quicksort(Inhand,0,Inhand.Length-1);
        }

        private int QuicksortFunc(int[] Numbers,int left, int right)
        {
            int basenum = Numbers[left];
            int i = left;
            int j = right;
            int temp;

            while (true)
            {
                if (Numbers[i] < basenum && i < j)
                    i++;
                else if (Numbers[i] > basenum && i < j)
                {
                    temp = Numbers[j];
                    Numbers[i] = Numbers[j];
                    Numbers[j] = temp;
                    j--;
                }
                else if (Numbers[j] < basenum && i < j)
                {
                    temp = Numbers[j];
                    Numbers[i] = Numbers[j];
                    Numbers[j] = temp;
                    i++;
                }
                else if (Numbers[j] > basenum && i < j)
                {
                    j--;
                }
                else if (i == j)
                {
                    Numbers[i] = basenum;
                    break;
                }
                return i;
            } 
            return i;
        }

        private void Quicksort(int[] n, int left, int right)
        {
            if (left<right)
            {
                int i = QuicksortFunc(n, left, right);
                QuicksortFunc(n, left, i - 1);
                QuicksortFunc(n, i+1, right);
            }
        }

        private void ShowLists()
        {
            for (int x = 0; x < 7; x++)
            {
                Console.WriteLine(sortnumber[x]);
            }
        }

        private void match()
        {

        }


    }
}
