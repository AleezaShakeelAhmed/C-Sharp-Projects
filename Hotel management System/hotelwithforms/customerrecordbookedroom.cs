using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotelwithforms.DL;
using hotelwithforms.BL;

namespace hotelwithforms
{
    public partial class customerrecordbookedroom : Form
    {
        public static string name;
        public static string idcard;
        public customerrecordbookedroom()
        {
            InitializeComponent();
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            receptionist r = new receptionist();
            r.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customerrecordbookedroom_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int idx = 0;
            name = textBox1.Text;
            idcard = textBox2.Text;
            while (true)
            {
                idcard = textBox2.Text;
                // validation for the id card number
                idx = idcard.Length;
                if (idx > 13 || idx < 13)
                {
                    MessageBox.Show("Invalid id card number!!!" + "\nPlease enter again:");
                    customerrecordbookedroom b = new customerrecordbookedroom();
                    b.ShowDialog();
                    idx = 0;
                    continue;
                }
                idx = 0;
                break;
            }
            this.Close();
            specificcustomer sc = new specificcustomer();
            sc.ShowDialog();
        }
    }
}
