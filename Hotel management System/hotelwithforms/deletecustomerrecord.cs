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

namespace hotelwithforms
{
    public partial class deletecustomerrecord : Form
    {
        public deletecustomerrecord()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            receptionist r = new receptionist();
            r.ShowDialog();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Deletecustomerrecord_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string name, idcard;
            name = textBox1.Text;
            idcard = textBox2.Text;
            customer c = new customer(name, idcard);
            for(int i = 0; i < DL.customerDL.customerlist.Count; i++)
            {
                if (c.Name == DL.customerDL.customerlist[i].Name && c.Idcardnumber == DL.customerDL.customerlist[i].Idcardnumber)
                {
                    DL.customerDL.customerlist.Remove(DL.customerDL.customerlist[i]);
                }
            }

            DL.customerDL.storeatonce();
            MessageBox.Show("Data deleted successfully");
        }
    }
}
