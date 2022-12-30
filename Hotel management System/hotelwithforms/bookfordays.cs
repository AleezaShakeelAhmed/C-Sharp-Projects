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
    public partial class bookfordays : Form
    {
        ComboBox c = new ComboBox();
        public bookfordays()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            room r = new room();
            r.Roomname = c.SelectedItem.ToString();
            r.Numberofdays = int.Parse(textBox2.Text);
            DL.roomDL.bookedroomlist.Add(r);
            this.Hide();



        }

        private void Bookfordays_Load(object sender, EventArgs e)
        {

            c.Location = new Point(455, 129);
            c.Size = new Size(121, 29);
            c.Name = "comboBox1";
            foreach (room rr in DL.roomDL.roomlist)
            {
                c.Items.Add(rr.Roomname);
            }
            this.Controls.Add(c);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
