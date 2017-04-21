using MessageBoard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoard
{
    public partial class Form2 : Form
    {

        //fields for mouse drag
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;


        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Close3b;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Close3a;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
                    
            }
            base.WndProc(ref m);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //mandag
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //tirsdag
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //onsdag
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //torsdag
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //fredag
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //mandag
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //tirsdag
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //onsdag
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //torsdag
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //fredag
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //mandag
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //tirsdag
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //onsdag
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //torsdag
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //fredag
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //mandag
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //tirsdag
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //onsdag    
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //torsdag
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //fredag
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //mandag
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //tirsdag
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //onsdag
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //torsdag
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //fredag
        }
    }
}
