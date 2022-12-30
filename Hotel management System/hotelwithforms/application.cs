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
    public partial class application : Form
    {
        public application()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            signin f = new signin();
            f.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            signupcs s = new signupcs();
            s.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
