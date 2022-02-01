using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace atestatpong
{
    public partial class Form6 : Form
    {
        public int speed = 5;
        public int ball_x = 5;
        public int ball_y = 5;
        public int scores = 0, scored= 0;
        public int ok = 0;
        public int k = 0;
        public Form6()
        {
            InitializeComponent();
            this.Text = "1VS1";
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {

            int x = player1.Location.X;
            int y = player1.Location.Y;
            if (e.KeyCode == Keys.W && player1.Top - 10 > 0 && ok != 1)
                y -= 10;
            if (e.KeyCode == Keys.S && player1.Top + player1.Height + 10 < ClientSize.Height && ok != 1)
                y += 10;

            player1.Location = new Point(x, y);


            int x1 = player2.Location.X;
            int y1 = player2.Location.Y;
            if (e.KeyCode == Keys.Up && player2.Top - 10 > 0 && ok != 1)
                y1 -= 10;
            if (e.KeyCode == Keys.Down && player2.Top + player2.Height + 10 < ClientSize.Height && ok != 1)
                y1 += 10;
            player2.Location = new Point(x1, y1);

            if (e.KeyCode == Keys.Space)
            {
                Form10 pause = new Form10();

                SoundPlayer player12 = new SoundPlayer();
                player12.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 2.wav";
                player12.Stop();
                gametimer1.Stop();
                pause.ShowDialog();
                if (pause.ok == 1)
                {
                    gametimer1.Start();
                    player12.PlayLooping(); 

                }
                if (pause.contor == 1)
                {

                    this.Visible = false;
                    Form1 pong = new Form1();
                    pong.ShowDialog();
                }
                if (pause.k == 1)
                {
                    this.Visible = false;
                } }
                if (e.KeyCode == Keys.M && k == 0)
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 2.wav";
                    player.Stop();
                    k = 1;
                }
                else
                    if (e.KeyCode == Keys.M && k == 1)
                    {
                        k = 0;
                        SoundPlayer player = new SoundPlayer();
                        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 2.wav";
                        player.PlayLooping();


                    }
            
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 2.wav";
            player.PlayLooping();
        }
        private void gametimer1_Tick(object sender, EventArgs e)
        {
            scorestanga.Text = "" + scores;
            scoretwo.Text = "" + scored;
            int btp = ball.Top + ball_y;
            int blft = ball.Left - ball_x;

            if (blft < 0)
            {
                ball.Left = ClientSize.Width / 2;
                ball.Top = ClientSize.Height / 2;
                ball_x = -ball_x;
                scored++;
            }
            else
                if (btp < 0 || btp + ball.Height > ClientSize.Height)
                    ball_y = -ball_y + 1;
                else
                    if (blft + ball.Width > ClientSize.Width)
                    {
                        ball.Left = ClientSize.Width / 2;
                        ball.Top = ClientSize.Height / 2;
                        ball_x = -ball_x;
                        scores++;
                    }
                    else
                    {
                        ball.Top = btp;
                        ball.Left = blft;
                        if (ball.Bounds.IntersectsWith(player2.Bounds))
                        {
                            ball_x = -ball_x - 1;
                        }
                        if (ball.Bounds.IntersectsWith(player1.Bounds))
                        { ball_x = -ball_x + 1;}
                    }


            if (scores == 10)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 3.wav";
                player.Play();
                gametimer1.Stop();
                MessageBox.Show("player 1 wins");
            }
            if (scored == 10)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 3.wav";
                player.Play();
                gametimer1.Stop();
                MessageBox.Show("player 2 wins");
            }
        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}
