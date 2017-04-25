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
    public partial class Form3 : Form
    {

        static List<Row> rows = new List<Row>();

        public Form3()
        {
            InitializeComponent();

            rows.AddRange(new Row[]
            {
                //en dags planlægning / gælder for alle dage
                new Row(11,richTextBox221,richTextBox243,richTextBox254,richTextBox232),
                new Row(10,richTextBox222,richTextBox244,richTextBox255,richTextBox233),
                new Row(9,richTextBox223,richTextBox245,richTextBox256,richTextBox234),
                new Row(8,richTextBox224,richTextBox246,richTextBox257,richTextBox235),
                new Row(7,richTextBox225,richTextBox247,richTextBox258,richTextBox236),
                new Row(6,richTextBox226,richTextBox248,richTextBox259,richTextBox237),
                new Row(5,richTextBox227,richTextBox249,richTextBox260,richTextBox238),
                new Row(4,richTextBox228,richTextBox250,richTextBox261,richTextBox239),
                new Row(3,richTextBox229,richTextBox251,richTextBox262,richTextBox240),
                new Row(2,richTextBox230,richTextBox252,richTextBox263,richTextBox241),
                new Row(1,richTextBox231,richTextBox253,richTextBox264,richTextBox242)
            });
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
                
            }
        }

        private void richTextBox258_TextChanged(object sender, EventArgs e)
        {

        }

        public static void CastingScreen()
        {
            DateTime dt = DateTime.Now;
            if(dt.DayOfWeek == DayOfWeek.Monday)
            {

                foreach (Row r in rows)
                    r.Udfyld(Dage.Mandag);
            }

            else if (dt.DayOfWeek == DayOfWeek.Tuesday)
            {

                foreach (Row r in rows)
                    r.Udfyld(Dage.Tirsdag);
            }

            else if(dt.DayOfWeek == DayOfWeek.Wednesday)
            {

                foreach (Row r in rows)
                    r.Udfyld(Dage.Onsdag);
            }
            
            else if(dt.DayOfWeek == DayOfWeek.Thursday)
            {

                foreach (Row r in rows)
                    r.Udfyld(Dage.Torsdag);
            }
            else if(dt.DayOfWeek == DayOfWeek.Friday)
            {

                foreach (Row r in rows)
                    r.Udfyld(Dage.Fredag);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                   
                    break;
                case DayOfWeek.Monday:
                    foreach (Row r in rows)
                        r.Udfyld(Dage.Mandag);
                    break;
                case DayOfWeek.Tuesday:
                    foreach (Row r in rows)
                        r.Udfyld(Dage.Tirsdag);
                    break;
                case DayOfWeek.Wednesday:
                    foreach (Row r in rows)
                        r.Udfyld(Dage.Onsdag);
                    break;
                case DayOfWeek.Thursday:
                    foreach (Row r in rows)
                        r.Udfyld(Dage.Torsdag);
                    break;
                case DayOfWeek.Friday:
                    foreach (Row r in rows)
                        r.Udfyld(Dage.Fredag);
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }
        }
    }
}
