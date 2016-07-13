using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker.AI
{
    class AI1
    {
        private int[] HandCard;
        private int Gold;


        AI1(int[] HandCard)
        {
            this.HandCard = HandCard;
            this.Gold = 0;
        }

        public void GetHandCard(int[] HandCard)
        {
            this.HandCard = HandCard;
        }


    }
}
