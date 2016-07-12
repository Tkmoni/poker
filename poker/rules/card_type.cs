using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace poker.rules
{
    public class card_type
    {
        private int[] card;
        private string[] cardtype;
        private int[] cardlist;
        private int movepoint;
        private int round;

        public card_type()
        {
            card = new int[52];
            cardtype = new string[4]{ "Diamond", "Heart", "Spade", "Club" };
            cardlist = new int[52];
            round = 3;
            movepoint = 0;
        }


        public void newcardlist()
        {
            int id;
            int site = 52;
            Random a = new  Random();
            movepoint = 0;
            //for (int x=0; x<52; x++)
            //{
            //    card[x] = x;

            // //   Console.WriteLine(card[x]);
            //}

            int cardnumber = 0;
            for (int x = 1; x < 5; x++)
            {
                for (int y = 1; y < 14; y++)
                {
                    card[cardnumber] = (x << 4) + y;
                    cardnumber++;
                }
            }



            for (int y=0; y<52; y++)
            {
                id = a.Next(0, site-1);
                cardlist[y] = card[id];
                site--;
                card[id] = card[site];
                
            }
        }


        public void Showlist()
        {
            for (int y = 0; y < 52; y++)
                Console.WriteLine(cardlist[y]&16);
        }

        public void SendCard()
        {
            movepoint += 2;
            round++;
        }

        public int[] SendHandCard()
        {
            int a = 3;
            int[] x = new int[2];

            while (a-->0)
            {
                x[a - 1] = cardlist[movepoint];
                movepoint++;
            }
            return x;
        }

        public int getRound()
        {
            return round;
        }
    }
}
