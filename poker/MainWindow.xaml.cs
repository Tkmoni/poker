using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using poker.rules;

namespace poker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void StartGame(object sender, RoutedEventArgs e)
        {

            card_type game = new card_type();
            int[] pile = new int[52];
            pile = game.newcardlist();
            int[,] PlayerCard=new int[10,2];
            int Nplayer = Int32.Parse(playerNB.Text);
            int Lplayer = Int32.Parse(playerLoc.Text);
            int CardNow = 0;
            for (int a=0; Nplayer>a;a++,CardNow++)
            {
                PlayerCard[a,0] = pile[CardNow];
                CardNow++;
                PlayerCard[a,1] = pile[CardNow];
            }
            ShowCardOnTable(PlayerCard,Nplayer, Lplayer);
        }

        public void ShowCardOnTable(int[,] Playercard, int Nplayer, int Lplayer)
        {
            for (int a=0; Nplayer>a; a++)
            {
                if (a != Lplayer)
                    Console.WriteLine("player" + a);
                else
                    Console.WriteLine("you");
                Console.WriteLine(Playercard[a, 0] + "♣" + Playercard[a, 1]);
            }
        }
    }
}
