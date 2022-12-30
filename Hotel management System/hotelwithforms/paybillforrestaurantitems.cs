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
    public partial class paybillforrestaurantitems : Form
    {
        float result = 0;
        float a = 20.0F;
        float b = 100.0F;
        public static float payable_by_customer = 0;
        public paybillforrestaurantitems()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            customerform c = new customerform();
            c.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Paybillforrestaurantitems_Load(object sender, EventArgs e)
        {
            float pay = 0;
            result = 0;
            foreach (product p in DL.productDL.productlist)
            {
                foreach (product pp in DL.productDL.orderedlist)
                {
                    if (pp.Productname == p.Productname)
                    {
                        result = result + p.Productprice;
                    }
                }
            }
            pay = result * a / b;
            payable_by_customer = result - pay;
            textBox1.Text = result.ToString();
            textBox2.Text = pay.ToString();
            textBox3.Text = payable_by_customer.ToString();
        }
    }
}
