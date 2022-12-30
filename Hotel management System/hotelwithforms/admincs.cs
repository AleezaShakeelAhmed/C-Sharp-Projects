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
    public partial class admincs : Form
    {
        public admincs()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            application a = new application();
            a.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            seepurchases s = new seepurchases();
            s.ShowDialog();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            calculateprofitloss c = new calculateprofitloss();
            c.ShowDialog();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            billreceivedaffterdiscount b = new billreceivedaffterdiscount();
            b.ShowDialog();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            employeerecord em = new employeerecord();
            em.ShowDialog();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            workerssalaryrecord w = new workerssalaryrecord();
            w.ShowDialog();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            deleteworkersandupdateworkersinformation d = new deleteworkersandupdateworkersinformation();
            d.ShowDialog();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            currentproducts c = new currentproducts();
            c.ShowDialog();
        }
    }
}
