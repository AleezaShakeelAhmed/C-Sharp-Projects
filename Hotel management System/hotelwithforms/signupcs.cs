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
using hotelwithforms.DL;

namespace hotelwithforms
{
    public partial class signupcs : Form
    {
        public signupcs()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            string role = textBox3.Text;
            credentials obj = new credentials(userName, password, role);
            DL.credentialsDL.store(obj);
            MessageBox.Show("Successfully added","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
