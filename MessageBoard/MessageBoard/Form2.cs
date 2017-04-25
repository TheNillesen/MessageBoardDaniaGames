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
    enum Dage {Mandag, Tirsdag, Onsdag, Torsdag, Fredag }
    public partial class Form2 : Form
    {
        

        //fields for mouse drag
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        List<Row> Rows = new List<Row>();

        public Form2()
        {
            InitializeComponent();

            Rows.AddRange(new Row[]
            {
                //en dags planlægning / gælder for alle dage
                new Row(11,richTextBox221,richTextBox243,richTextBox254,richTextBox232,checkBox56),
                new Row(10,richTextBox222,richTextBox244,richTextBox255,richTextBox233,checkBox58),
                new Row(9,richTextBox223,richTextBox245,richTextBox256,richTextBox234,checkBox57),
                new Row(8,richTextBox224,richTextBox246,richTextBox257,richTextBox235,checkBox60),
                new Row(7,richTextBox225,richTextBox247,richTextBox258,richTextBox236,checkBox59),
                new Row(6,richTextBox226,richTextBox248,richTextBox259,richTextBox237,checkBox62),
                new Row(5,richTextBox227,richTextBox249,richTextBox260,richTextBox238,checkBox61),
                new Row(4,richTextBox228,richTextBox250,richTextBox261,richTextBox239,checkBox64),
                new Row(3,richTextBox229,richTextBox251,richTextBox262,richTextBox240,checkBox63),
                new Row(2,richTextBox230,richTextBox252,richTextBox263,richTextBox241,checkBox65),
                new Row(1,richTextBox231,richTextBox253,richTextBox264,richTextBox242,checkBox66)
            });
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

        //til screen drag
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Mandag

            foreach (Row r in Rows)
                r.Udfyld(Dage.Mandag);
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //tirsdag
            foreach (Row r in Rows)
                r.Udfyld(Dage.Tirsdag);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            //onsdag

            foreach (Row r in Rows)
                r.Udfyld(Dage.Onsdag);




        }

        private void button8_Click(object sender, EventArgs e)
        {
            //torsdag

            foreach (Row r in Rows)
                r.Udfyld(Dage.Torsdag);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //fredag
            foreach (Row r in Rows)
                r.Udfyld(Dage.Fredag);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            foreach (Row r in Rows)
                r.Save();
        }

        private void chooseAll_Click(object sender, EventArgs e)
        {
            foreach (Row r in Rows)
                r.checkBox.Checked = !r.checkBox.Checked;
        }

        private void nulstil_Click(object sender, EventArgs e)
        {
            foreach (Row r in Rows)
                r.deleteRow();
        }
    }
}
