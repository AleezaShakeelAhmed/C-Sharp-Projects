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
    public partial class availablerooms : Form
    {
        public availablerooms()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            customerform c = new customerform();
            c.ShowDialog();
        }

        public void Txttotalroomsavaliable_TextChanged(object sender, EventArgs e)
        {
            txttotalroomsavaliable.Text = calculateroms.calculateroomss().ToString();
        }
    }
}
