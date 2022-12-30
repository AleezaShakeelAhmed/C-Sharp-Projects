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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            credentials obj = new credentials(userName, password);
            DL.credentialsDL.readFromFile();
            string result= DL.credentialsDL.searchforsignin(obj);
            if(result == "receptionist")
            {
                receptionist myForm = new receptionist();
                myForm.ShowDialog();
            }
            else if (result == "customer")
            {
                customerform c = new customerform();
                c.ShowDialog();
            }
            else if (result == "admin")
            {
                admincs a = new admincs();
                a.ShowDialog();
            }
            else if (result == "worker")
            {
                workerform w = new workerform();
                w.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid user...");
            }
            
        }
    }
}
