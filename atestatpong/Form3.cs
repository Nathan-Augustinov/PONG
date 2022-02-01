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
    public partial class Form3 : Form
    {

        public int speed = 5;
        public int ball_x = 5;
        public int ball_y = 5;
        public int score = 0, cpupoint = 0;
        public int q = 10;
        public int ok = 0;
        public int k = 0;


        public Form3()
        {
            InitializeComponent();
            this.Text = "EASY";
        }
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            int x = player.Location.X;
            int y = player.Location.Y;
            if (e.KeyCode == Keys.Up && player.Top - 10 > 0 && ok!=1)
                y -= 10;
            if (e.KeyCode == Keys.Down && player.Top + player.Height + 10 < ClientSize.Height && ok!=1)
                y += 10;

            player.Location = new Point(x, y);
            if(e.KeyCode==Keys.Space)
            {
                Form7 pause = new Form7();
               
                SoundPlayer player1 = new SoundPlayer();
                player1.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 2.wav";
                player1.Stop();
                gametimer1.Stop();
                pause.ShowDialog();
                if (pause.ok == 1)
                { gametimer1.Start();
                player1.PlayLooping();
                    
                }
                if (pause.contor == 1)
                {
                    
                    this.Visible = false;
                    Form1 pong = new Form1();
                    pong.ShowDialog();
                }
                if(pause.k==1)
                {
                    this.Visible = false;
                }
                
               

            }
            if(e.KeyCode==Keys.M && k==0)
            {
                SoundPlayer player1 = new SoundPlayer();
                player1.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 2.wav";
                player1.Stop();
                k = 1;
            }
            else
                if(e.KeyCode==Keys.M && k==1)
                {
                    k = 0;
                    SoundPlayer player1 = new SoundPlayer();
                player1.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 2.wav";
                player1.PlayLooping();


                }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 2.wav";
                player.PlayLooping();
            }

        }

        public void gametimer1_Tick(object sender, EventArgs e)
        {
            pscore.Text = "" + score;
            cpuscore.Text = "" + cpupoint;
            int btp = ball.Top + ball_y;
            int blft = ball.Left - ball_x;
            cpu.Top += speed;

            if (cpu.Top < 0 || cpu.Top + cpu.Height > ClientSize.Height)
                speed = -speed;

            if (blft < 0)
            {

                ball.Left = ClientSize.Width / 2;
                ball.Top = ClientSize.Height / 2;
                ball_x = -ball_x;
              
                cpupoint++;
            }
            else
                if (btp < 0 || btp + ball.Height > ClientSize.Height)

                    ball_y = -ball_y;

                else

                    if (blft + ball.Width > ClientSize.Width)
                    {

                        ball.Left = ClientSize.Width / 2;
                        ball.Top = ClientSize.Height / 2;
                        ball_x = -ball_x;
                        //ball_x += 2;
                        score++;
                    }
                    else
                    {

                        ball.Top = btp;
                        ball.Left = blft;
                        if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
                        {
                            ball_x = -ball_x;

                        }
                    }

     
            if (cpu.Top + q > 0 || cpu.Top + cpu.Height + q < ClientSize.Height)
                q = -q;
            if (score >= 10)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 3.wav";
                player.Play();
                gametimer1.Stop();
                MessageBox.Show("You are the winner!!");
            }
            if (cpupoint >= 10)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\56459_Martin_Galway_Ping_Pong___Title__Beeper__1 4.wav";
                player.Play();
                gametimer1.Stop();
                MessageBox.Show("You are a loser");
            }
        }

        

        
    }
}