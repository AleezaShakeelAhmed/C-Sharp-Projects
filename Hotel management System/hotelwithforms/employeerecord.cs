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
    public partial class employeerecord : Form
    {
        public employeerecord()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            admincs a = new admincs();
            a.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string workername, workerexperience;
            int age;
            double salary;
            workername = textBox2.Text;
            age = int.Parse(textBox1.Text);
            while (true)
            {
                age = int.Parse(textBox1.Text);
                // validation for the age
                if (age > 35 || age < 20)
                {
                    MessageBox.Show("Invalid age!!!" + "\nPlease enter again:");
                    employeerecord b = new employeerecord();
                    b.ShowDialog();
                    age = 0;
                    continue;
                }
                break;
            }
            salary = double.Parse(textBox3.Text);
            workerexperience = textBox4.Text;
            worker w = new worker(workername,salary,age, workerexperience);
            DL.workerDL.addworkerintolist(w);
            DL.workerDL.sorting();
            DL.workerDL.addinfile(w);
            MessageBox.Show("Added successfully");
            admincs a =new admincs();
            a.ShowDialog();


        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
