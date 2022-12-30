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
    public partial class booktheroom : Form
    {
        public booktheroom()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void Button2_Click_1(object sender, EventArgs e)
        {

            int index = 0, idx = 0;
            customer c = new customer();
            c.Name = textBox1.Text;
            while (true)
            {
                c.Idcardnumber = textBox2.Text;
                // validation for the id card number
                idx = c.Idcardnumber.Length;
                if (idx > 13 || idx < 13)
                {
                    MessageBox.Show("Invalid id card number!!!"+ "\nPlease enter again:");
                    booktheroom b = new booktheroom();
                    b.ShowDialog();
                    idx = 0;
                    continue;
                }
                idx = 0;
                break;
            }
            DL.customerDL.addcustomersintolist(c);
            int numberofrooms = int.Parse(textBox3.Text);
            MessageBox.Show("number of rooms = " + numberofrooms);
            while (index < numberofrooms)
            {
                bookfordays b1 = new bookfordays();
                b1.ShowDialog();
                index++;
            }
            DL.customerDL.storecustomerdataintofile(c);
            this.Close();
            customerform ccc = new customerform();
            ccc.ShowDialog();
            
               
          
        }
    }
}
