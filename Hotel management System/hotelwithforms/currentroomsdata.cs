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
    public partial class currentroomsdata : Form
    {
        public currentroomsdata()
        {
            InitializeComponent();
            Room_data_grid.DataSource = DL.roomDL.roomlist;
            Room_data_grid.Columns["numberofdays"].Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            receptionist r = new receptionist();
            r.ShowDialog();
        }

        private void Room_data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
