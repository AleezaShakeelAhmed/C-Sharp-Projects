using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotelwithforms.DL;
using hotelwithforms.BL;

namespace hotelwithforms
{
    public partial class workerssalaryrecord : Form
    {
        public workerssalaryrecord()
        {
            InitializeComponent();
            gvSalary.DataSource = DL.workerDL.workerlist;
            gvSalary.Columns["workerage"].Visible = false;
            gvSalary.Columns["workerexperience"].Visible = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            admincs a = new admincs();
            a.ShowDialog();
        }
    }
}
