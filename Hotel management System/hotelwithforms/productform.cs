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
    public partial class productform : Form
    {
        public productform()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           string productname=textBox2.Text;
           float productprice=float.Parse(textBox3.Text);
            product p = new product(productprice,productname);
            DL.productDL.storeinfile(p);
            MessageBox.Show("Successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            workerform wf = new workerform();
            wf.ShowDialog();

        }
    }
}
