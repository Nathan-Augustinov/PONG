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
    public partial class Form8 : Form
    {
        public int ok = 0, contor = 0, k;
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 easy = new Form5();
            this.Hide();
            easy.ShowDialog();
            easy.gametimer1.Start();
            k = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ok = 1;
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
             contor = 1;


            this.Close();
        }
    }
}
