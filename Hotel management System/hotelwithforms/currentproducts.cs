﻿using System;
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
    public partial class currentproducts : Form
    {
        public currentproducts()
        {
            InitializeComponent();
            gvproducts.DataSource = DL.productDL.productlist;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            admincs a = new admincs();
            a.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void currentproducts_Load(object sender, EventArgs e)
        {

        }
    }
}
