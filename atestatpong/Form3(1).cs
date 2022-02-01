using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestatpong
{
    public partial class Form3 : Form
    {
        
        public int speed = 5;
        public int ball_x = 5;
        public int ball_y = 5;
        public int score = 0, cpupoint = 0;

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            int x = player.Location.X;
            int y = player.Location.Y;
            if (e.KeyCode == Keys.Up)
                y = y - 10;
            if (e.KeyCode == Keys.Down)
                y = y - 10;
            player.Location = new Point(x, y);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        
    }
}
