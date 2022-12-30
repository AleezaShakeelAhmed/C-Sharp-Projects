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
    public partial class deleteworkersandupdateworkersinformation : Form
    {
        public deleteworkersandupdateworkersinformation()
        {
            InitializeComponent();
            gvdeleteWorker.DataSource = DL.workerDL.workerlist;
        }

        private void Deleteworkersandupdateworkersinformation_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            admincs a = new admincs();
            a.ShowDialog();
        }

        private void GvdeleteWorker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gvdeleteWorker.Columns["Delete"].Index == e.ColumnIndex)
            {
                int index = gvdeleteWorker.CurrentCell.RowIndex;
                worker obj = (worker)gvdeleteWorker.CurrentRow.DataBoundItem;
                gvdeleteWorker.DataSource = null;
                DL.workerDL.deleteWorker(index);
                 DL.workerDL.addalllistatonceintifile();
                gvdeleteWorker.DataSource = DL.workerDL.workerlist;
                gvdeleteWorker.Refresh();
            }
        }
    }
}
