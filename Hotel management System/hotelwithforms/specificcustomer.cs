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
    public partial class specificcustomer : Form
    {
        public specificcustomer()
        {
            InitializeComponent();
            foreach(customer c in DL.customerDL.customerlist)
            {
                if (customerrecordbookedroom.name == c.Name && customerrecordbookedroom.idcard == c.Idcardnumber)
                {
                    gvroomdata.DataSource = DL.roomDL.bookedroomlist;
                    gvroomdata.Columns["numberofdays"].Visible = false;
                    gvroomdata.Columns["roomprice"].Visible = false;



                }
            }
            MessageBox.Show(" "+DL.roomDL.bookedroomlist.Count);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            receptionist cf = new receptionist();
            cf.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
