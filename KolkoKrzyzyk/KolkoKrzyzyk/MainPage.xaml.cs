using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;

namespace KolkoKrzyzyk
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            
            Clear();

        }

        private int[] Board = new int[9];
        private string[] Players = new string[2];
        private int Turn = 0;
        private bool End = false;
        private bool Draw=false;
        int PlayerTurn;
        bool Won = false;
        Uri uriNew = new Uri(@"/pusty.jpg", UriKind.RelativeOrAbsolute);
        Uri uriO = new Uri(@"/o.jpg", UriKind.RelativeOrAbsolute);
        Uri uriX = new Uri(@"/x.jpg", UriKind.RelativeOrAbsolute);
        private void Clear()
        {
            Turn = 0;
            End = false;
            Won = false;
            Draw = false;
            PlayerTurn = (Turn % 2);
            Players[0] = "Player O";
            Players[1] = "Player X";
            for (int i = 0; i < Board.Length; i++)
            {
                Board[i] = 2;
            }
            
            image0.Source = new BitmapImage(uriNew);
            image1.Source = new BitmapImage(uriNew);
            image2.Source = new BitmapImage(uriNew);
            image3.Source = new BitmapImage(uriNew);
            image4.Source = new BitmapImage(uriNew);
            image5.Source = new BitmapImage(uriNew);
            image6.Source = new BitmapImage(uriNew);
            image7.Source = new BitmapImage(uriNew);
            image8.Source = new BitmapImage(uriNew);

            DisplayScoreTurn();
        }


        private void CheckWin()
        {
            
            

            if (Board[0] == PlayerTurn && Board[1] == PlayerTurn && Board[2] == PlayerTurn)
            {
                Won = true;
            }
            if (Board[3] == PlayerTurn && Board[4] == PlayerTurn && Board[5] == PlayerTurn)
            {
                Won = true;
            }
            if (Board[6] == PlayerTurn && Board[7] == PlayerTurn && Board[8] == PlayerTurn)
            {
                Won = true;
            }
            if (Board[0] == PlayerTurn && Board[3] == PlayerTurn && Board[6] == PlayerTurn)
            {
                Won = true;
            }
            if (Board[1] == PlayerTurn && Board[4] == PlayerTurn && Board[7] == PlayerTurn)
            {
                Won = true;
            }
            if (Board[2] == PlayerTurn && Board[5] == PlayerTurn && Board[8] == PlayerTurn)
            {
                Won = true;
            }
            if (Board[0] == PlayerTurn && Board[4] == PlayerTurn && Board[8] == PlayerTurn)
            {
                Won = true;
            }
            if (Board[2] == PlayerTurn && Board[4] == PlayerTurn && Board[6] == PlayerTurn)
            {
                Won = true;
            }

            if (Won)
            {
                End = true;
                DisplayScoreTurn();
            }
            else
            {
                Turn++;
                PlayerTurn = (Turn % 2);
                DisplayScoreTurn();
            }
            if (Turn > 8)
            {
                End = true;
                Draw = true;
                DisplayScoreTurn();
            }
        }




        private void LayoutRoot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point CurrentPoint = e.GetPosition(LayoutRoot);
            int position = (Convert.ToInt16(CurrentPoint.X) / 151) + ((Convert.ToInt16(CurrentPoint.Y) / 151) * 3);
            if (position < 9)
            {


                if (!End)
                {
                    if (Board[position] == 2)
                    {
                        Board[position] = PlayerTurn;
                        if (position == 0)
                        {
                            if (PlayerTurn == 0)
                            {
                                image0.Source = new BitmapImage(uriO);
                            }
                            if (PlayerTurn == 1)
                            {
                                image0.Source = new BitmapImage(uriX);
                            }
                        }
                        if (position == 1)
                        {
                            if (PlayerTurn == 0)
                            {
                                image1.Source = new BitmapImage(uriO);
                            }
                            if (PlayerTurn == 1)
                            {
                                image1.Source = new BitmapImage(uriX);
                            }
                        }
                        if (position == 2)
                        {
                            if (PlayerTurn == 0)
                            {
                                image2.Source = new BitmapImage(uriO);
                            }
                            if (PlayerTurn == 1)
                            {
                                image2.Source = new BitmapImage(uriX);
                            }
                        }
                        if (position == 3)
                        {
                            if (PlayerTurn == 0)
                            {
                                image3.Source = new BitmapImage(uriO);
                            }
                            if (PlayerTurn == 1)
                            {
                                image3.Source = new BitmapImage(uriX);
                            }
                        }
                        if (position == 4)
                        {
                            if (PlayerTurn == 0)
                            {
                                image4.Source = new BitmapImage(uriO);
                            }
                            if (PlayerTurn == 1)
                            {
                                image4.Source = new BitmapImage(uriX);
                            }
                        }
                        if (position == 5)
                        {
                            if (PlayerTurn == 0)
                            {
                                image5.Source = new BitmapImage(uriO);
                            }
                            if (PlayerTurn == 1)
                            {
                                image5.Source = new BitmapImage(uriX);
                            }
                        }
                        if (position == 6)
                        {
                            if (PlayerTurn == 0)
                            {
                                image6.Source = new BitmapImage(uriO);
                            }
                            if (PlayerTurn == 1)
                            {
                                image6.Source = new BitmapImage(uriX);
                            }
                        }
                        if (position == 7)
                        {
                            if (PlayerTurn == 0)
                            {
                                image7.Source = new BitmapImage(uriO);
                            }
                            if (PlayerTurn == 1)
                            {
                                image7.Source = new BitmapImage(uriX);
                            }
                        }
                        if (position == 8)
                        {
                            if (PlayerTurn == 0)
                            {
                                image8.Source = new BitmapImage(uriO);
                            }
                            if (PlayerTurn == 1)
                            {
                                image8.Source = new BitmapImage(uriX);
                            }
                        }
                        //DisplayScoreTurn();
                        CheckWin();
                        
                    }
                    
                }
                
                
                //Info.Text = CurrentPoint.X + "; " + CurrentPoint.Y + "\n" + position;
            }

            
        }
        void DisplayScoreTurn()
        {
            if (Draw)
            {
                Info.Text = "Draw!";
            }
            else if (End)
            {
                Info.Text = Players[PlayerTurn] + " wins!";
            }
            else
            {
                Info.Text = Players[PlayerTurn] + " turn";// +"\n" + Turn + "\n" + PlayerTurn;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clear();
        }
    }
}