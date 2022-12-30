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
    public partial class changepriceofroom : Form
    {
        public changepriceofroom()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Changepriceofroom_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            receptionist r = new receptionist();
            r.ShowDialog();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string newprice = textBox2.Text;
            room rr = new room(name, newprice);
            foreach(room r in DL.roomDL.roomlist)
            {
                if (rr.Roomname == r.Roomname)
                {
                    r.Roomprice = rr.Roomprice;   
                }
            }
            DL.roomDL.storeintofile();
            MessageBox.Show("Data updated succesfully");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
