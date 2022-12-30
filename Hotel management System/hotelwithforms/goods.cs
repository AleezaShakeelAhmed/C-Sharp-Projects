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
    public partial class goods : Form
    {
        public goods()
        {
            InitializeComponent();
            gvgoods.DataSource = DL.productDL.productlist;
        }

        private void Gvgoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for(int j = 0; j < 1; j++)
            {
                order i = new order();
                i.ShowDialog();
            }
            this.Hide();

        }
    }
}
