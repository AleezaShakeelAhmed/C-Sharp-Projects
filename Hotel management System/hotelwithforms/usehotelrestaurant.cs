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
    public partial class usehotelrestaurant : Form
    {
        public usehotelrestaurant()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int idx = 0;
            string name, idcardnumber;
            name = textBox1.Text;
            while (true)
            {
                idcardnumber = textBox2.Text;
                // validation for the id card number
                idx = idcardnumber.Length;
                if (idx > 13 || idx < 13)
                {
                    MessageBox.Show("Invalid id card number!!!" + "\nPlease enter again:");
                    usehotelrestaurant b = new usehotelrestaurant();
                    b.ShowDialog();
                    idx = 0;
                    continue;
                }
                idx = 0;
                break;
            }
            customer c = new customer(name, idcardnumber);
            DL.customerDL.addcustomersintolist(c);
            for(int i = 0; i < 1; i++)
            {
                goods g = new goods();
                g.ShowDialog();
            }
            DL.customerDL.storeorderedproductsinformation(c);
            customerform cf = new customerform();
            cf.ShowDialog();
            this.Hide();
        }
    }
}
