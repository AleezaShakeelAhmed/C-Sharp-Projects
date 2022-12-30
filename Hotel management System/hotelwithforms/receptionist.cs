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
    public partial class receptionist: Form
    {
        public receptionist()
        {
            InitializeComponent();
        }
        private void Label4_Click(object sender, EventArgs e)
        {
            currentroomsdata cr = new currentroomsdata();
            cr.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            calculateroms r = new calculateroms();
            r.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            application a = new application();
            a.ShowDialog();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            customerrecordbookedroom b = new customerrecordbookedroom();
            b.ShowDialog();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            deletecustomerrecord d = new deletecustomerrecord();
            d.ShowDialog();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            changepriceofroom cp = new changepriceofroom();
            cp.ShowDialog();
        }
    }
}
