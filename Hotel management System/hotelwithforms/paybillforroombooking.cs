using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotelwithforms.BL;
using hotelwithforms.DL;

namespace hotelwithforms
{
    public partial class paybillforroombooking : Form
    {
        public paybillforroombooking()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            customerform c = new customerform();
            c.ShowDialog();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            double res = 0;
            string name = textBox1.Text;
            int days = int.Parse(textBox2.Text);
            foreach(room r in DL.roomDL.roomlist)
            {
                if (name == r.Roomname)
                {
                    float a = int.Parse(r.Roomprice);
                    res = a * days;
                }
            }
            textBox3.Text = res.ToString();


        }
    }
}
