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
    public partial class items : Form
    {
        public items()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string nameofitem = textBox1.Text;
            product p = new product(nameofitem);
            DL.productDL.orderedlist.Add(p);
            this.Hide();

        }
    }
}
