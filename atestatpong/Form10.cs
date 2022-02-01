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
    public partial class Form10 : Form
    {
        public int ok = 0, contor = 0, k;
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 easy = new Form6();
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
