using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoard
{
    class Row
    {

        private Dage dag;
        public RichTextBox lokale;
        public RichTextBox skib;
        public RichTextBox lærer;
        public RichTextBox aktivitet;
        public CheckBox checkBox;
        private int id;

        public bool ShowShip
        {
            get
            {
                return skib.Visible;
            }

            set
            {
                skib.Visible = value;
            }
        }

        public Row(int id, RichTextBox lokale, RichTextBox skib, RichTextBox aktivitet, RichTextBox lærer, CheckBox checkBox)
        {

            this.id = id; //0
            this.skib = skib; //2
            this.lærer = lærer; //4
            this.lokale = lokale; //1 
            this.checkBox = checkBox;
            this.aktivitet = aktivitet; //3
        }

        public Row(int id, RichTextBox lokale, RichTextBox skib, RichTextBox aktivitet, RichTextBox lærer)
        {

            this.id = id; //0
            this.skib = skib; //2
            this.lærer = lærer; //4
            this.lokale = lokale; //1
            this.aktivitet = aktivitet; //3
        }


        public void Udfyld(Dage dag)
        {
            this.dag = dag;
            string[] values = sqlDatabase.Instance.GetValues(dag, id);

            if (values == null)
            {
                skib.Text = aktivitet.Text = lærer.Text = lokale.Text = "";
            }
            else
            {
                skib.Text = values[2];
                aktivitet.Text = values[3];
                lærer.Text = values[4];
                lokale.Text = values[1];
            }

        }

        public void Save()
        {

            sqlDatabase.Instance.Values(id, dag, lokale.Text, skib.Text, lærer.Text, aktivitet.Text);
        }
        public void deleteRow()
        {
            if (checkBox.Checked)
            {
                
                skib.Text = aktivitet.Text = lærer.Text = lokale.Text = "";
                Save();
            }


        }
    }
}
