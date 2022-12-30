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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Load functions
            DL.roomDL.readFromFile();
            DL.productDL.readFromFile();
            DL.workerDL.readFromFile();
            DL.customerDL.readFromFileroom();
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            application myForm = new application();
            myForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
