﻿using System;
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
        card_type game = new card_type();
        public MainWindow()
        {
            InitializeComponent();
        }


        public void mmain()
        {
            //card_type game = new card_type();
            int[] pile = new int[52];
            //pile = game.newcardlist();
            int[,] PlayerCard = new int[10, 2];
            int PlayerNumber = Int32.Parse(playerNB.Text);
            int PlayerLocation = Int32.Parse(playerLoc.Text);
            //for (int a = 0; Nplayer > a; a++, CardNow++)
            //{
            //    PlayerCard[a, 0] = pile[CardNow];
            //    CardNow++;
            //    PlayerCard[a, 1] = pile[CardNow];
            //}
            for (int a = 0; PlayerNumber > a; a++)
            {
                int[] temp = game.SendHandCard();
                PlayerCard[a, 0] = temp[0];
                PlayerCard[a, 1] = temp[1];
            }


            ShowCardOnTable(PlayerCard, PlayerNumber, PlayerLocation);
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            Gamestate.Text = "";

            game.newcardlist();

            Gamestate.Inlines.Add("\nGame has been started!");

            mmain();

            Gamestate.Inlines.Add("\nSending handcards!");
            Gamestate.Inlines.Add("\nYour cards is " + "*****");
        }

        public void ShowCardOnTable(int[,] Playercard, int Nplayer, int Lplayer)
        {
            for (int a=0; Nplayer>a; a++)
            {
                if (a != Lplayer-1)
                    Console.WriteLine("player" + a);
                else
                    Console.WriteLine("you");
                Console.WriteLine(Playercard[a, 0] + " " + Playercard[a, 1]);
            }
        }

        private void Giveup(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gameover");
            Gamestate.Inlines.Add("\nGame is over. Waitting a new game!");
        }

        private void PlayerAsk()
        {
            
        }

        private void Resume(object sender, RoutedEventArgs e)
        {
            game.Showlist();
            JudgeWin();
        }

        private void JudgeWin()
        {

            int[] PlayerNo = new int[2 + game.getRound()];
            for (int a = 0; a<2+game.getRound(); a++)
                Console.Write(PlayerNo[a]);

            
        }

        private void ExitGame(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
