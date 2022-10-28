using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Kniffel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Random rnd = new Random();
        private int würfeler = 4;
        private int würfeltime = 90;
        private int player1_würfel1 = 0;
        private int player1_würfel2 = 0;
        private int player1_würfel3 = 0;
        private int player1_würfel4 = 0;
        private int player1_würfel5 = 0;
        private int player2_würfel1 = 0;
        private int player2_würfel2 = 0;
        private int player2_würfel3 = 0;
        private int player2_würfel4 = 0;
        private int player2_würfel5 = 0;
        private Boolean isplayer1 = true;
        private Boolean isplayer2 = false;
        private int player1_würfel = 5;
        private int player2_würfel = 5;
        private int trys = 3;
        private int storedwürfel1 = 0;
        private int storedwürfel2 = 0;
        private int storedwürfel3 = 0;
        private int storedwürfel4 = 0;
        private int storedwürfel5 = 0;
        private List<int> storedwürfel = new List<int>();
        private bool button1_disabled = false;
        private bool button2_disabled = false;
        private bool button3_disabled = false;
        private bool button4_disabled = false;
        private bool button5_disabled = false;
        private int scoreplayer1 = 0;
        private int scoreplayer2 = 0;
        private int tempresult1 = 0;
        private int tempresult2 = 0;
        private int tempresult3 = 0;
        private int tempresult4 = 0;
        private int tempresult5 = 0;
        private int tempresult6 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }


        public void sync_playerview()
        {
            lab_player1view.Visibility = Visibility.Collapsed;
            lab_player2view.Visibility = Visibility.Collapsed;
            lab_1trys.Visibility = Visibility.Hidden;
            lab_2trys.Visibility = Visibility.Hidden;
            lab_3trys.Visibility = Visibility.Hidden;
            if (isplayer1)
            {
                lab_player1view.Visibility = Visibility.Visible;
            }else if (isplayer2)
            {
                lab_player2view.Visibility = Visibility.Visible;
            }

            if (trys == 3)
            {
                lab_3trys.Visibility = Visibility.Visible;
            }else if(trys == 2)
            {
                lab_2trys.Visibility = Visibility.Visible;
            }else if(trys == 1)
            {
                lab_1trys.Visibility = Visibility.Visible;
            }
        }

        public void sync()
        {
            //würfel1 reset
            img_main_würfel1p1.Visibility = Visibility.Hidden;
            img_main_würfel1p2.Visibility = Visibility.Hidden;
            img_main_würfel1p3.Visibility = Visibility.Hidden;
            img_main_würfel1p4.Visibility = Visibility.Hidden;
            img_main_würfel1p5.Visibility = Visibility.Hidden;
            img_main_würfel1p6.Visibility = Visibility.Hidden;
            //würfel2 reset
            img_main_würfel2p1.Visibility = Visibility.Hidden;
            img_main_würfel2p2.Visibility = Visibility.Hidden;
            img_main_würfel2p3.Visibility = Visibility.Hidden;
            img_main_würfel2p4.Visibility = Visibility.Hidden;
            img_main_würfel2p5.Visibility = Visibility.Hidden;
            img_main_würfel2p6.Visibility = Visibility.Hidden;
            //würfel3 reset
            img_main_würfel3p1.Visibility = Visibility.Hidden;
            img_main_würfel3p2.Visibility = Visibility.Hidden;
            img_main_würfel3p3.Visibility = Visibility.Hidden;
            img_main_würfel3p4.Visibility = Visibility.Hidden;
            img_main_würfel3p5.Visibility = Visibility.Hidden;
            img_main_würfel3p6.Visibility = Visibility.Hidden;
            //würfel4 reset
            img_main_würfel4p1.Visibility = Visibility.Hidden;
            img_main_würfel4p2.Visibility = Visibility.Hidden;
            img_main_würfel4p3.Visibility = Visibility.Hidden;
            img_main_würfel4p4.Visibility = Visibility.Hidden;
            img_main_würfel4p5.Visibility = Visibility.Hidden;
            img_main_würfel4p6.Visibility = Visibility.Hidden;
            //würfel5 reset
            img_main_würfel5p1.Visibility = Visibility.Hidden;
            img_main_würfel5p2.Visibility = Visibility.Hidden;
            img_main_würfel5p3.Visibility = Visibility.Hidden;
            img_main_würfel5p4.Visibility = Visibility.Hidden;
            img_main_würfel5p5.Visibility = Visibility.Hidden;
            img_main_würfel5p6.Visibility = Visibility.Hidden;



            if (isplayer1)
            {


                if (player1_würfel1 == 1)
                {
                    img_main_würfel1p1.Visibility = Visibility.Visible;
                }
                else if (player1_würfel1 == 2)
                {
                    img_main_würfel1p2.Visibility = Visibility.Visible;
                }
                else if (player1_würfel1 == 3)
                {
                    img_main_würfel1p3.Visibility = Visibility.Visible;
                }
                else if (player1_würfel1 == 4)
                {
                    img_main_würfel1p4.Visibility = Visibility.Visible;
                }
                else if (player1_würfel1 == 5)
                {
                    img_main_würfel1p5.Visibility = Visibility.Visible;
                }
                else if (player1_würfel1 == 6)
                {
                    img_main_würfel1p6.Visibility = Visibility.Visible;
                }



                if (player1_würfel2 == 1)
                {
                    img_main_würfel2p1.Visibility = Visibility.Visible;
                }
                else if (player1_würfel2 == 2)
                {
                    img_main_würfel2p2.Visibility = Visibility.Visible;
                }
                else if (player1_würfel2 == 3)
                {
                    img_main_würfel2p3.Visibility = Visibility.Visible;
                }
                else if (player1_würfel2 == 4)
                {
                    img_main_würfel2p4.Visibility = Visibility.Visible;
                }
                else if (player1_würfel2 == 5)
                {
                    img_main_würfel2p5.Visibility = Visibility.Visible;
                }
                else if (player1_würfel2 == 6)
                {
                    img_main_würfel2p6.Visibility = Visibility.Visible;
                }



                if (player1_würfel3 == 1)
                {
                    img_main_würfel3p1.Visibility = Visibility.Visible;
                }
                else if (player1_würfel3 == 2)
                {
                    img_main_würfel3p2.Visibility = Visibility.Visible;
                }
                else if (player1_würfel3 == 3)
                {
                    img_main_würfel3p3.Visibility = Visibility.Visible;
                }
                else if (player1_würfel3 == 4)
                {
                    img_main_würfel3p4.Visibility = Visibility.Visible;
                }
                else if (player1_würfel3 == 5)
                {
                    img_main_würfel3p5.Visibility = Visibility.Visible;
                }
                else if (player1_würfel3 == 6)
                {
                    img_main_würfel3p6.Visibility = Visibility.Visible;
                }



                if (player1_würfel4 == 1)
                {
                    img_main_würfel4p1.Visibility = Visibility.Visible;
                }
                else if (player1_würfel4 == 2)
                {
                    img_main_würfel4p2.Visibility = Visibility.Visible;
                }
                else if (player1_würfel4 == 3)
                {
                    img_main_würfel4p3.Visibility = Visibility.Visible;
                }
                else if (player1_würfel4 == 4)
                {
                    img_main_würfel4p4.Visibility = Visibility.Visible;
                }
                else if (player1_würfel4 == 5)
                {
                    img_main_würfel4p5.Visibility = Visibility.Visible;
                }
                else if (player1_würfel4 == 6)
                {
                    img_main_würfel4p6.Visibility = Visibility.Visible;
                }


                if (player1_würfel5 == 1)
                {
                    img_main_würfel5p1.Visibility = Visibility.Visible;
                }
                else if (player1_würfel5 == 2)
                {
                    img_main_würfel5p2.Visibility = Visibility.Visible;
                }
                else if (player1_würfel5 == 3)
                {
                    img_main_würfel5p3.Visibility = Visibility.Visible;
                }
                else if (player1_würfel5 == 4)
                {
                    img_main_würfel5p4.Visibility = Visibility.Visible;
                }
                else if (player1_würfel5 == 5)
                {
                    img_main_würfel5p5.Visibility = Visibility.Visible;
                }
                else if (player1_würfel5 == 6)
                {
                    img_main_würfel4p6.Visibility = Visibility.Visible;
                }
            }
            else if (isplayer2)
            {


                    if (player2_würfel1 == 1)
                    {
                        img_main_würfel1p1.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel1 == 2)
                    {
                        img_main_würfel1p2.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel1 == 3)
                    {
                        img_main_würfel1p3.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel1 == 4)
                    {
                        img_main_würfel1p4.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel1 == 5)
                    {
                        img_main_würfel1p5.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel1 == 6)
                    {
                        img_main_würfel1p6.Visibility = Visibility.Visible;
                    }



                    if (player2_würfel2 == 1)
                    {
                        img_main_würfel2p1.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel2 == 2)
                    {
                        img_main_würfel2p2.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel2 == 3)
                    {
                        img_main_würfel2p3.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel2 == 4)
                    {
                        img_main_würfel2p4.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel2 == 5)
                    {
                        img_main_würfel2p5.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel2 == 6)
                    {
                        img_main_würfel2p6.Visibility = Visibility.Visible;
                    }



                    if (player2_würfel3 == 1)
                    {
                        img_main_würfel3p1.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel3 == 2)
                    {
                        img_main_würfel3p2.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel3 == 3)
                    {
                        img_main_würfel3p3.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel3 == 4)
                    {
                        img_main_würfel3p4.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel3 == 5)
                    {
                        img_main_würfel3p5.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel3 == 6)
                    {
                        img_main_würfel3p6.Visibility = Visibility.Visible;
                    }



                    if (player2_würfel4 == 1)
                    {
                        img_main_würfel4p1.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel4 == 2)
                    {
                        img_main_würfel4p2.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel4 == 3)
                    {
                        img_main_würfel4p3.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel4 == 4)
                    {
                        img_main_würfel4p4.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel4 == 5)
                    {
                        img_main_würfel4p5.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel4 == 6)
                    {
                        img_main_würfel4p6.Visibility = Visibility.Visible;
                    }


                    if (player2_würfel5 == 1)
                    {
                        img_main_würfel5p1.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel5 == 2)
                    {
                        img_main_würfel5p2.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel5 == 3)
                    {
                        img_main_würfel5p3.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel5 == 4)
                    {
                        img_main_würfel5p4.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel5 == 5)
                    {
                        img_main_würfel5p5.Visibility = Visibility.Visible;
                    }
                    else if (player2_würfel5 == 6)
                    {
                        img_main_würfel4p6.Visibility = Visibility.Visible;
                    }
                }
            }
        private async void Start_würfeln(object sender, RoutedEventArgs e)
        {
            if (this.isplayer1)
            {
                player1_würfel1 = 0;
                player1_würfel2 = 0;
                player1_würfel3 = 0;
                player1_würfel4 = 0;
                player1_würfel5 = 0;
                if (player1_würfel == 5)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for(int i = 0; i < würfeler; i++)
                    {
                        player1_würfel1 = rnd.Next(1, 6);
                        player1_würfel2 = rnd.Next(1, 6);
                        player1_würfel3 = rnd.Next(1, 6);
                        player1_würfel4 = rnd.Next(1, 6);
                        player1_würfel5 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime/würfeler));
                    }
                    player1_würfel1 = rnd.Next(1, 6);
                    player1_würfel2 = rnd.Next(1, 6);
                    player1_würfel3 = rnd.Next(1, 6);
                    player1_würfel4 = rnd.Next(1, 6);
                    player1_würfel5 = rnd.Next(1, 6);

                    button1_disabled = true;
                    button2_disabled = true;
                    button3_disabled = true;
                    button4_disabled = true;
                    button5_disabled = true;
                }
                if (player1_würfel == 4)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for (int i = 0; i < würfeler; i++)
                    {
                        player1_würfel1 = rnd.Next(1, 6);
                        player1_würfel2 = rnd.Next(1, 6);
                        player1_würfel3 = rnd.Next(1, 6);
                        player1_würfel4 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime / würfeler));
                    }
                    player1_würfel1 = rnd.Next(1, 6);
                    player1_würfel2 = rnd.Next(1, 6);
                    player1_würfel3 = rnd.Next(1, 6);
                    player1_würfel4 = rnd.Next(1, 6);

                    button1_disabled = true;
                    button2_disabled = true;
                    button3_disabled = true;
                    button4_disabled = true;
                    button5_disabled = false;
                }
                if (player1_würfel == 3)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for (int i = 0; i < würfeler; i++)
                    {
                        player1_würfel2 = rnd.Next(1, 6);
                        player1_würfel3 = rnd.Next(1, 6);
                        player1_würfel4 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime / würfeler));
                    }
                    player1_würfel2 = rnd.Next(1, 6);
                    player1_würfel3 = rnd.Next(1, 6);
                    player1_würfel4 = rnd.Next(1, 6);

                    button1_disabled = false;
                    button2_disabled = true;
                    button3_disabled = true;
                    button4_disabled = true;
                    button5_disabled = false;
                }
                if (player1_würfel == 2)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for (int i = 0; i < würfeler; i++)
                    {
                        player1_würfel2 = rnd.Next(1, 6);
                        player1_würfel4 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime / würfeler));
                    }
                    player1_würfel2 = rnd.Next(1, 6);
                    player1_würfel4 = rnd.Next(1, 6);

                    button1_disabled = false;
                    button2_disabled = true;
                    button3_disabled = false;
                    button4_disabled = true;
                    button5_disabled = false;
                }
                if (player1_würfel == 1)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for (int i = 0; i < würfeler; i++)
                    {
                        player1_würfel3 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime / würfeler));
                    }
                    player1_würfel3 = rnd.Next(1, 6);

                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = true;
                    button4_disabled = false;
                    button5_disabled = false;
                }
                if (trys <= 0)
                {
                    isplayer1 = false;
                    isplayer2 = true;
                    trys = 3;
                    player2_würfel = 5;
                    player1_würfel1 = 0;
                    player1_würfel2 = 0;
                    player1_würfel3 = 0;
                    player1_würfel4 = 0;
                    player1_würfel5 = 0;
                    tempresult1 = 0;
                    tempresult2 = 0;
                    tempresult3 = 0;
                    tempresult4 = 0;
                    tempresult5 = 0;
                    tempresult6 = 0;
                    for (int i = 0; i < storedwürfel.Count; i++)
                    {
                        if (storedwürfel[i] == 1)
                        {
                            tempresult1++;
                        }
                        if (storedwürfel[i] == 2)
                        {
                            tempresult2++;
                        }
                        if (storedwürfel[i] == 3)
                        {
                            tempresult3++;
                        }
                        if (storedwürfel[i] == 4)
                        {
                            tempresult4++;
                        }
                        if (storedwürfel[i] == 5)
                        {
                            tempresult5++;
                        }
                        if (storedwürfel[i] == 6)
                        {
                            tempresult6++;
                        }
                    }
                    if (tempresult1 >= 3)
                    {
                        if (scoreplayer1 > 0)
                        {
                            scoreplayer1 = scoreplayer1 + 10 * (tempresult1 - 2);
                        }
                        else
                        {
                            scoreplayer1 = 10 * (tempresult1 - 2);
                        }
                    }
                    if (tempresult2 >= 4)
                    {
                        if (scoreplayer1 > 0)
                        {
                            scoreplayer1 = scoreplayer1 + 2 * (tempresult2 - 3);
                        }
                        else
                        {
                            scoreplayer1 = 2 * (tempresult2 - 2);
                        }
                    }
                    if (tempresult3 >= 3)
                    {
                        if (scoreplayer1 > 0)
                        {
                            scoreplayer1 = scoreplayer1 + 3 * (tempresult3 - 2);
                        }
                        else
                        {
                            scoreplayer1 = 3 * (tempresult3 - 2);
                        }
                    }
                    if (tempresult4 >= 3)
                    {
                        if (scoreplayer1 > 0)
                        {
                            scoreplayer1 = scoreplayer1 + 4 * (tempresult4 - 2);
                        }
                        else
                        {
                            scoreplayer1 = 4 * (tempresult4 - 2);
                        }
                    }
                    if (tempresult5 >= 3)
                    {
                        if (scoreplayer1 > 0)
                        {
                            scoreplayer1 = scoreplayer1 + 5 * (tempresult5 - 2);
                        }
                        else
                        {
                            scoreplayer1 = 5 * (tempresult5 - 2);
                        }
                    }
                    if (tempresult6 >= 3)
                    {
                        if (scoreplayer1 > 0)
                        {
                            scoreplayer1 = scoreplayer1 + 6 * (tempresult6 - 2);
                        }
                        else
                        {
                            scoreplayer1 = 6 * (tempresult6 - 2);
                        }
                    }
                    if (tempresult1 == 1 && tempresult2 == 1 && tempresult3 == 1 && tempresult4 == 1 && tempresult5 == 1)
                    {
                        if (scoreplayer1 > 0)
                        {
                            scoreplayer1 = scoreplayer1 + 30;
                        }
                        else
                        {
                            scoreplayer1 = 30;
                        }
                    }
                    sync_scores();
                    storedwürfel.Clear();
                    storedwürfel1 = 0;
                    storedwürfel2 = 0;
                    storedwürfel3 = 0;
                    storedwürfel4 = 0;
                    storedwürfel5 = 0;
                    sync_storedwürfel();
                }
                else
                {
                    trys--;
                }
                sync();
                sync_playerview();
            }
            else if (this.isplayer2)
            {
                player2_würfel1 = 0;
                player2_würfel2 = 0;
                player2_würfel3 = 0;
                player2_würfel4 = 0;
                player2_würfel5 = 0;
                if (player2_würfel == 5)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for(int i = 0; i < würfeler; i++)
                    {
                        player2_würfel1 = rnd.Next(1, 6);
                        player2_würfel2 = rnd.Next(1, 6);
                        player2_würfel3 = rnd.Next(1, 6);
                        player2_würfel4 = rnd.Next(1, 6);
                        player2_würfel5 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime/würfeler));
                    }
                    player2_würfel1 = rnd.Next(1, 6);
                    player2_würfel2 = rnd.Next(1, 6);
                    player2_würfel3 = rnd.Next(1, 6);
                    player2_würfel4 = rnd.Next(1, 6);
                    player2_würfel5 = rnd.Next(1, 6);

                    button1_disabled = true;
                    button2_disabled = true;
                    button3_disabled = true;
                    button4_disabled = true;
                    button5_disabled = true;
                }
                if (player2_würfel == 4)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for (int i = 0; i < würfeler; i++)
                    {
                        player2_würfel1 = rnd.Next(1, 6);
                        player2_würfel2 = rnd.Next(1, 6);
                        player2_würfel3 = rnd.Next(1, 6);
                        player2_würfel4 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime / würfeler));
                    }
                    player2_würfel1 = rnd.Next(1, 6);
                    player2_würfel2 = rnd.Next(1, 6);
                    player2_würfel3 = rnd.Next(1, 6);
                    player2_würfel4 = rnd.Next(1, 6);

                    button1_disabled = true;
                    button2_disabled = true;
                    button3_disabled = true;
                    button4_disabled = true;
                    button5_disabled = false;
                }
                if (player2_würfel == 3)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for (int i = 0; i < würfeler; i++)
                    {
                        player2_würfel2 = rnd.Next(1, 6);
                        player2_würfel3 = rnd.Next(1, 6);
                        player2_würfel4 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime / würfeler));
                    }
                    player2_würfel2 = rnd.Next(1, 6);
                    player2_würfel3 = rnd.Next(1, 6);
                    player2_würfel4 = rnd.Next(1, 6);

                    button1_disabled = false;
                    button2_disabled = true;
                    button3_disabled = true;
                    button4_disabled = true;
                    button5_disabled = false;
                }
                if (player2_würfel == 2)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for (int i = 0; i < würfeler; i++)
                    {

                        player2_würfel2 = rnd.Next(1, 6);
                        player2_würfel4 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime / würfeler));
                    }
                    player2_würfel2 = rnd.Next(1, 6);
                    player2_würfel4 = rnd.Next(1, 6);

                    button1_disabled = false;
                    button2_disabled = true;
                    button3_disabled = false;
                    button4_disabled = true;
                    button5_disabled = false;
                }
                if (player2_würfel == 1)
                {
                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = false;
                    button4_disabled = false;
                    button5_disabled = false;

                    for (int i = 0; i < würfeler; i++)
                    {
                        player2_würfel3 = rnd.Next(1, 6);
                        sync();
                        await Task.Run(() => Thread.Sleep(würfeltime / würfeler));
                    }
                    player2_würfel3 = rnd.Next(1, 6);

                    button1_disabled = false;
                    button2_disabled = false;
                    button3_disabled = true;
                    button4_disabled = false;
                    button5_disabled = false;
                }
                if (trys <= 0)
                    {
                        isplayer1 = true;
                        isplayer2 = false;
                        trys = 3;
                    player1_würfel = 5;
                    player2_würfel1 = 0;
                    player2_würfel2 = 0;
                    player2_würfel3 = 0;
                    player2_würfel4 = 0;
                    player2_würfel5 = 0;
                    tempresult1 = 0;
                    tempresult2 = 0;
                    tempresult3 = 0;
                    tempresult4 = 0;
                    tempresult5 = 0;
                    tempresult6 = 0;
                    for(int i = 0; i < storedwürfel.Count; i++)
                    {
                        if (storedwürfel[i] == 1)
                        {
                            tempresult1++;
                        }
                        if (storedwürfel[i] == 2)
                        {
                            tempresult2++;
                        }
                        if (storedwürfel[i] == 3)
                        {
                            tempresult3++;
                        }
                        if (storedwürfel[i] == 4)
                        {
                            tempresult4++;
                        }
                        if (storedwürfel[i] == 5)
                        {
                            tempresult5++;
                        }
                        if (storedwürfel[i] == 6)
                        {
                            tempresult6++;
                        }
                    }
                    if (tempresult1 >= 3)
                    {
                        if (scoreplayer2 > 0)
                        {
                            scoreplayer2 = scoreplayer2 + 10* (tempresult1 - 2);
                        }
                        else
                        {
                            scoreplayer2 = 10* (tempresult1 - 2);
                        }
                    }
                    if (tempresult2 >= 4)
                    {
                        if (scoreplayer2 > 0)
                        {
                            scoreplayer2 = scoreplayer2 + 2 * (tempresult2 - 3);
                        }
                        else
                        {
                            scoreplayer2 = 2 * (tempresult2 - 3);
                        }
                    }
                    if (tempresult3 >= 3)
                    {
                        if (scoreplayer2 > 0)
                        {
                            scoreplayer2 = scoreplayer2 + 3 * (tempresult3 - 2);
                        }
                        else
                        {
                            scoreplayer2 = 3 * (tempresult3 - 2);
                        }
                    }
                    if (tempresult4 >= 3)
                    {
                        if (scoreplayer2 > 0)
                        {
                            scoreplayer2 = scoreplayer2 + 4 * (tempresult4 - 2);
                        }
                        else
                        {
                            scoreplayer2 = 4 * (tempresult4 - 2);
                        }
                    }
                    if (tempresult5 >= 3)
                    {
                        if (scoreplayer2 > 0)
                        {
                            scoreplayer2 = scoreplayer2 + 5 * (tempresult5 - 2);
                        }
                        else
                        {
                            scoreplayer2 = 5 * (tempresult5 - 2);
                        }
                    }
                    if (tempresult6 >= 3)
                    {
                        if (scoreplayer2 > 0)
                        {
                            scoreplayer2 = scoreplayer2 + 6 * (tempresult6 - 2);
                        }
                        else
                        {
                            scoreplayer2 = 6 * (tempresult6 - 2);
                        }
                    }
                    if (tempresult1 == 1 && tempresult2 == 1 && tempresult3 == 1 && tempresult4 == 1 && tempresult5 == 1)
                    {
                        if (scoreplayer2 > 0)
                        {
                            scoreplayer2 = scoreplayer2 +30;
                        }
                        else
                        {
                            scoreplayer2 = 30;
                        }
                    }
                    sync_scores();
                    storedwürfel.Clear();
                    storedwürfel1 = 0;
                    storedwürfel2 = 0;
                    storedwürfel3 = 0;
                    storedwürfel4 = 0;
                    storedwürfel5 = 0;
                    sync_storedwürfel();
                }
                else
                    {
                        trys--;
                    }
                    sync();
                    sync_playerview();
                }
            }

        private void Start_Game(object sender, RoutedEventArgs e)
        {
            btn_startgame.Visibility = Visibility.Collapsed;
            div_gamepad.Visibility = Visibility.Visible;
            sync_playerview();
        }

        private void storewürfel1(object sender, RoutedEventArgs e)
        {
            if (button1_disabled)
            {
                if (isplayer1)
                {
                    if (player1_würfel >= 1)
                    {
                        storedwürfel.Add(player1_würfel1);
                        player1_würfel--;
                        img_main_würfel1p1.Visibility = Visibility.Hidden;
                        img_main_würfel1p2.Visibility = Visibility.Hidden;
                        img_main_würfel1p3.Visibility = Visibility.Hidden;
                        img_main_würfel1p4.Visibility = Visibility.Hidden;
                        img_main_würfel1p5.Visibility = Visibility.Hidden;
                        img_main_würfel1p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button1_disabled = false;
                    }
                }
                else
                {
                    if (player2_würfel >= 1)
                    {
                        player2_würfel--;
                        storedwürfel.Add(player2_würfel1);
                        img_main_würfel1p1.Visibility = Visibility.Hidden;
                        img_main_würfel1p2.Visibility = Visibility.Hidden;
                        img_main_würfel1p3.Visibility = Visibility.Hidden;
                        img_main_würfel1p4.Visibility = Visibility.Hidden;
                        img_main_würfel1p5.Visibility = Visibility.Hidden;
                        img_main_würfel1p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button1_disabled = false;
                    }
                }
            }
        }

        private void storewürfel2(object sender, RoutedEventArgs e)
        {
            if (button2_disabled)
            {
                if (isplayer1)
                {
                    if (player1_würfel >= 1)
                    {
                        storedwürfel.Add(player1_würfel2);
                        player1_würfel--;
                        img_main_würfel2p1.Visibility = Visibility.Hidden;
                        img_main_würfel2p2.Visibility = Visibility.Hidden;
                        img_main_würfel2p3.Visibility = Visibility.Hidden;
                        img_main_würfel2p4.Visibility = Visibility.Hidden;
                        img_main_würfel2p5.Visibility = Visibility.Hidden;
                        img_main_würfel2p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button2_disabled = false;
                    }
                }
                else
                {
                    if (player2_würfel >= 1)
                    {
                        player2_würfel--;
                        storedwürfel.Add(player2_würfel2);
                        img_main_würfel2p1.Visibility = Visibility.Hidden;
                        img_main_würfel2p2.Visibility = Visibility.Hidden;
                        img_main_würfel2p3.Visibility = Visibility.Hidden;
                        img_main_würfel2p4.Visibility = Visibility.Hidden;
                        img_main_würfel2p5.Visibility = Visibility.Hidden;
                        img_main_würfel2p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button2_disabled = false;
                    }
                }
            }
        }

        private void storewürfel3(object sender, RoutedEventArgs e)
        {
            if (button3_disabled)
            {
                if (isplayer1)
                {
                    if (player1_würfel >= 1)
                    {
                        storedwürfel.Add(player1_würfel3);
                        player1_würfel--;
                        img_main_würfel3p1.Visibility = Visibility.Hidden;
                        img_main_würfel3p2.Visibility = Visibility.Hidden;
                        img_main_würfel3p3.Visibility = Visibility.Hidden;
                        img_main_würfel3p4.Visibility = Visibility.Hidden;
                        img_main_würfel3p5.Visibility = Visibility.Hidden;
                        img_main_würfel3p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button3_disabled = false;
                    }
                }
                else
                {
                    if (player2_würfel >= 1)
                    {
                        player2_würfel--;
                        storedwürfel.Add(player2_würfel3);
                        img_main_würfel3p1.Visibility = Visibility.Hidden;
                        img_main_würfel3p2.Visibility = Visibility.Hidden;
                        img_main_würfel3p3.Visibility = Visibility.Hidden;
                        img_main_würfel3p4.Visibility = Visibility.Hidden;
                        img_main_würfel3p5.Visibility = Visibility.Hidden;
                        img_main_würfel3p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button3_disabled = false;
                    }
                }
            }
        }

        private void storewürfel4(object sender, RoutedEventArgs e)
        {
            if (button4_disabled)
            {
                if (isplayer1)
                {
                    if (player1_würfel >= 1)
                    {
                        storedwürfel.Add(player1_würfel4);
                        player1_würfel--;
                        img_main_würfel4p1.Visibility = Visibility.Hidden;
                        img_main_würfel4p2.Visibility = Visibility.Hidden;
                        img_main_würfel4p3.Visibility = Visibility.Hidden;
                        img_main_würfel4p4.Visibility = Visibility.Hidden;
                        img_main_würfel4p5.Visibility = Visibility.Hidden;
                        img_main_würfel4p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button4_disabled = false;
                    }
                }
                else
                {
                    if (player2_würfel >= 1)
                    {
                        player2_würfel--;
                        storedwürfel.Add(player2_würfel4);
                        img_main_würfel4p1.Visibility = Visibility.Hidden;
                        img_main_würfel4p2.Visibility = Visibility.Hidden;
                        img_main_würfel4p3.Visibility = Visibility.Hidden;
                        img_main_würfel4p4.Visibility = Visibility.Hidden;
                        img_main_würfel4p5.Visibility = Visibility.Hidden;
                        img_main_würfel4p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button4_disabled = false;
                    }
                }
            }
        }

        private void storewürfel5(object sender, RoutedEventArgs e)
        {
            if (button5_disabled)
            {
                if (isplayer1)
                {
                    if (player1_würfel >= 1)
                    {
                        storedwürfel.Add(player1_würfel5);
                        player1_würfel--;
                        img_main_würfel5p1.Visibility = Visibility.Hidden;
                        img_main_würfel5p2.Visibility = Visibility.Hidden;
                        img_main_würfel5p3.Visibility = Visibility.Hidden;
                        img_main_würfel5p4.Visibility = Visibility.Hidden;
                        img_main_würfel5p5.Visibility = Visibility.Hidden;
                        img_main_würfel5p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button5_disabled = false;
                    }
                }
                else
                {
                    if (player2_würfel >= 1)
                    {
                        player2_würfel--;
                        storedwürfel.Add(player2_würfel5);
                        img_main_würfel5p1.Visibility = Visibility.Hidden;
                        img_main_würfel5p2.Visibility = Visibility.Hidden;
                        img_main_würfel5p3.Visibility = Visibility.Hidden;
                        img_main_würfel5p4.Visibility = Visibility.Hidden;
                        img_main_würfel5p5.Visibility = Visibility.Hidden;
                        img_main_würfel5p6.Visibility = Visibility.Hidden;
                        sync_storedwürfel();
                        button5_disabled = false;
                    }
                }
            }
        }

        public void sync_storedwürfel()
        {
            //würfel1 reset
            img_stored_würfel1p1.Visibility = Visibility.Hidden;
            img_stored_würfel1p2.Visibility = Visibility.Hidden;
            img_stored_würfel1p3.Visibility = Visibility.Hidden;
            img_stored_würfel1p4.Visibility = Visibility.Hidden;
            img_stored_würfel1p5.Visibility = Visibility.Hidden;
            img_stored_würfel1p6.Visibility = Visibility.Hidden;
            //würfel2 reset
            img_stored_würfel2p1.Visibility = Visibility.Hidden;
            img_stored_würfel2p2.Visibility = Visibility.Hidden;
            img_stored_würfel2p3.Visibility = Visibility.Hidden;
            img_stored_würfel2p4.Visibility = Visibility.Hidden;
            img_stored_würfel2p5.Visibility = Visibility.Hidden;
            img_stored_würfel2p6.Visibility = Visibility.Hidden;
            //würfel3 reset
            img_stored_würfel3p1.Visibility = Visibility.Hidden;
            img_stored_würfel3p2.Visibility = Visibility.Hidden;
            img_stored_würfel3p3.Visibility = Visibility.Hidden;
            img_stored_würfel3p4.Visibility = Visibility.Hidden;
            img_stored_würfel3p5.Visibility = Visibility.Hidden;
            img_stored_würfel3p6.Visibility = Visibility.Hidden;
            //würfel4 reset
            img_stored_würfel4p1.Visibility = Visibility.Hidden;
            img_stored_würfel4p2.Visibility = Visibility.Hidden;
            img_stored_würfel4p3.Visibility = Visibility.Hidden;
            img_stored_würfel4p4.Visibility = Visibility.Hidden;
            img_stored_würfel4p5.Visibility = Visibility.Hidden;
            img_stored_würfel4p6.Visibility = Visibility.Hidden;
            //würfel5 reset
            img_stored_würfel5p1.Visibility = Visibility.Hidden;
            img_stored_würfel5p2.Visibility = Visibility.Hidden;
            img_stored_würfel5p3.Visibility = Visibility.Hidden;
            img_stored_würfel5p4.Visibility = Visibility.Hidden;
            img_stored_würfel5p5.Visibility = Visibility.Hidden;
            img_stored_würfel5p6.Visibility = Visibility.Hidden;

            if(storedwürfel.Count >= 1)
            {
                storedwürfel1 = storedwürfel[0];
            }
            if(storedwürfel.Count >= 2)
            {
                storedwürfel2 = storedwürfel[1];
            }
            if (storedwürfel.Count >= 3)
            {
                storedwürfel3 = storedwürfel[2];
            }
            if (storedwürfel.Count >= 4)
            {
                storedwürfel4 = storedwürfel[3];
            }
            if (storedwürfel.Count >= 5)
            {
                storedwürfel5 = storedwürfel[4];
            }

            if (storedwürfel1 == 1)
            {
                img_stored_würfel1p1.Visibility = Visibility.Visible;
            }
            else if(storedwürfel1 == 2)
            {
                img_stored_würfel1p2.Visibility = Visibility.Visible;
            }else if(storedwürfel1 == 3)
            {
                img_stored_würfel1p3.Visibility = Visibility.Visible;
            }else if(storedwürfel1 == 4)
            {
                img_stored_würfel1p4.Visibility = Visibility.Visible;
            }else if(storedwürfel1 == 5)
            {
                img_stored_würfel1p5.Visibility = Visibility.Visible;
            }else if(storedwürfel1 == 6)
            {
                img_stored_würfel1p6.Visibility = Visibility.Visible;
            }



            if (storedwürfel2 == 1)
            {
                img_stored_würfel2p1.Visibility = Visibility.Visible;
            }
            else if (storedwürfel2 == 2)
            {
                img_stored_würfel2p2.Visibility = Visibility.Visible;
            }
            else if (storedwürfel2 == 3)
            {
                img_stored_würfel2p3.Visibility = Visibility.Visible;
            }
            else if (storedwürfel2 == 4)
            {
                img_stored_würfel2p4.Visibility = Visibility.Visible;
            }
            else if (storedwürfel2 == 5)
            {
                img_stored_würfel2p5.Visibility = Visibility.Visible;
            }
            else if (storedwürfel2 == 6)
            {
                img_stored_würfel2p6.Visibility = Visibility.Visible;
            }



            if (storedwürfel3 == 1)
            {
                img_stored_würfel3p1.Visibility = Visibility.Visible;
            }
            else if (storedwürfel3 == 2)
            {
                img_stored_würfel3p2.Visibility = Visibility.Visible;
            }
            else if (storedwürfel3 == 3)
            {
                img_stored_würfel3p3.Visibility = Visibility.Visible;
            }
            else if (storedwürfel3 == 4)
            {
                img_stored_würfel3p4.Visibility = Visibility.Visible;
            }
            else if (storedwürfel3 == 5)
            {
                img_stored_würfel3p5.Visibility = Visibility.Visible;
            }
            else if (storedwürfel3 == 6)
            {
                img_stored_würfel3p6.Visibility = Visibility.Visible;
            }



            if (storedwürfel4 == 1)
            {
                img_stored_würfel4p1.Visibility = Visibility.Visible;
            }
            else if (storedwürfel4 == 2)
            {
                img_stored_würfel4p2.Visibility = Visibility.Visible;
            }
            else if (storedwürfel4 == 3)
            {
                img_stored_würfel4p3.Visibility = Visibility.Visible;
            }
            else if (storedwürfel4 == 4)
            {
                img_stored_würfel4p4.Visibility = Visibility.Visible;
            }
            else if (storedwürfel4 == 5)
            {
                img_stored_würfel4p5.Visibility = Visibility.Visible;
            }
            else if (storedwürfel4 == 6)
            {
                img_stored_würfel4p6.Visibility = Visibility.Visible;
            }



            if (storedwürfel5==1)
            {
                img_stored_würfel5p1.Visibility = Visibility.Visible;
            }
            else if (storedwürfel5 == 2)
            {
                img_stored_würfel5p2.Visibility = Visibility.Visible;
            }
            else if (storedwürfel5 == 3)
            {
                img_stored_würfel5p3.Visibility = Visibility.Visible;
            }
            else if (storedwürfel5 == 4)
            {
                img_stored_würfel5p4.Visibility = Visibility.Visible;
            }
            else if (storedwürfel5 == 5)
            {
                img_stored_würfel5p5.Visibility = Visibility.Visible;
            }
            else if (storedwürfel5 == 6)
            {
                img_stored_würfel5p6.Visibility = Visibility.Visible;
            }
        }
        public void sync_scores()
        {
            lab_scoreplayer1.Content = scoreplayer1;
            lab_scoreplayer2.Content = scoreplayer2;
        }
    }
}
