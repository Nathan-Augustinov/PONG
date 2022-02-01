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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "PONG";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 vspc = new Form2();
            this.Visible = false;
            vspc.ShowDialog();
            this.Close();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form6 twoplayers= new Form6();
            this.Visible=false;
            twoplayers.ShowDialog();
            this.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
