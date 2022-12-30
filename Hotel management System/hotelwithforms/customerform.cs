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
    public partial class customerform : Form
    {
        public customerform()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            application a = new application();
            a.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            availablerooms a = new availablerooms();
            a.ShowDialog();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            currentroomsincustomer cr = new currentroomsincustomer();
            cr.ShowDialog();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            booktheroom br = new booktheroom();
            br.ShowDialog();


        }

        private void Label6_Click(object sender, EventArgs e)
        {
            usehotelrestaurant u = new usehotelrestaurant();
            u.ShowDialog();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            discount d = new discount();
            d.ShowDialog();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            paybillforrestaurantitems p = new paybillforrestaurantitems();
            p.ShowDialog();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            paybillforroombooking p = new paybillforroombooking();
            p.ShowDialog();
        }
    }
}
