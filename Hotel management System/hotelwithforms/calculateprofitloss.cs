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
    public partial class calculateprofitloss : Form
    {
        int a=0, b=0;
        int result = 0;
        public calculateprofitloss()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            admincs a = new admincs();
            a.ShowDialog();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

           
           

        }

        private void Calculateprofitloss_Load(object sender, EventArgs e)
        {
           
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            result = b - a;
            if (result > 0)
            {
                textBox4.Text = " ";
                textBox3.Text = result.ToString();
            }
            else if(result < 0)
            {
                textBox3.Text = " ";
                textBox4.Text = result.ToString();
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
