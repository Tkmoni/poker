using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace poker.rules
{
    class card_type
    {
        
        

        public card_type()
        {
            int[] card = new int[52];
            string[] cardtype = { "Diamond", "Heart", "Spade", "Club" };
            int[] cardlist = newcardlist();
        }


        public int[] newcardlist()
        {
            int[] card = new int[52];            
            int[] list = new int[52];
            int id;
            int site = 52;
            Random a = new  Random();

            for (int x=0; x<52; x++)
            {
                card[x] = x;
                Console.WriteLine(card[x]);
            }

            for (int y=0; y<52; y++)
            {
                id = a.Next(0, site-1);
                list[y] = card[id];
                site--;
                card[id] = card[site];
                
            }

            
            return list;
        }
        public void Showlist()
        {

        }

    }
}
