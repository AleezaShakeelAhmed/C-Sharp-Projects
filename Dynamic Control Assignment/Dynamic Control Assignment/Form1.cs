using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Control_Assignment
{
    public partial class Form1 : Form
    {
        public int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnNext_Click(object sender, EventArgs e)
        {
            total = int.Parse(txtmaininput.Text);
            AddBoxes(total);
        }
        public  void AddBoxes(int input1)
        {
            int y_Add = 39;
            for (int i = 1; i <= input1; i++)
            {
                TextBox newcreated = new TextBox();
                newcreated.Name = "txtsubject" + i;
                newcreated.Location = new Point(515, (69+y_Add));
                newcreated.Size = new Size(171, 28);
                newcreated.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                this.Controls.Add(newcreated);
                y_Add += 39;
            }
        }

        private void sumbton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= total; i++)
            {
                sum =sum + int.Parse(this.Controls["txtsubject"+i].Text);
            }
            MessageBox.Show("The Sum is Equal To = "+sum.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
