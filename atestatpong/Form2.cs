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
    public partial class Form2 : Form
         
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Levels";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 easy=new Form3();
            this.Visible = false;
            easy.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 medium = new Form4();
            this.Visible = false;
            medium.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 hard = new Form5();
            this.Visible = false;
            hard.ShowDialog();
            this.Close();
        }
    }
}
