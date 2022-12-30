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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int index = 0;
            int number = int.Parse(textBox2.Text);
            MessageBox.Show("number of items = " + number);
            while (index < number)
            { 
                items i = new items();
                i.ShowDialog();
                index++;
            }
            MessageBox.Show("Items added successfully");
            this.Hide();




        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
