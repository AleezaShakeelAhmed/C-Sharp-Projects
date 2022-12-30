using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelwithforms
{
    public partial class calculateroms : Form
    {
       public static int total = 0, booked = 0, avaliable = 0;
        public calculateroms()
        {
            InitializeComponent();
        }
         public static int calculateroomss()
        {
            return avaliable = total - booked;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            receptionist r = new receptionist();
            r.ShowDialog();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            avaliable = total - booked;
            txtavaliable.Text = avaliable.ToString();
         
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
             total = int.Parse(txttotalrooms.Text);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            booked = int.Parse(txtbookedrooms.Text);
        }
    }
}
