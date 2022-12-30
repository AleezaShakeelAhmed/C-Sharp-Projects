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
    public partial class discount : Form
    {
        public discount()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            customerform c = new customerform();
            c.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string dis = textBox1.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK!");
        }
    }
}
