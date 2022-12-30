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
    public partial class seepurchases : Form
    {
        public seepurchases()
        {
            InitializeComponent();
            gvsailed.DataSource = DL.productDL.orderedlist;
            gvsailed.Columns["productprice"].Visible = false;

        }

        private void Seepurchases_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            admincs a = new admincs();
            a.ShowDialog();

        }

        private void Gvsailed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
