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

        public card_type()
        {
            card = new int[52];
            cardtype = new string[4]{ "Diamond", "Heart", "Spade", "Club" };
            cardlist = new int[52];
        }


        public void newcardlist()
        {
            int id;
            int site = 52;
            Random a = new  Random();

            for (int x=0; x<52; x++)
            {
                card[x] = x;

             //   Console.WriteLine(card[x]);
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
                Console.WriteLine(cardlist[y]);
        }

    }
}
