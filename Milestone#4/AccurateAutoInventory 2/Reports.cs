using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccurateAutoInventory
{
    public partial class RunReports : Form
    {
        private string report1 = "inventory";
        private string report2 = "models";
        private string report3 = "type";

        public RunReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill in the textbox");
            }
            else if (textBox1.Text == report1)
            {
                MessageBox.Show("return Report1 ");  //once vehicle database is implemented these messageboxes can be modified to reflect actual reports
            }
            else if (textBox1.Text == report2)
            {
                MessageBox.Show("return Report2");
            }
            else if (textBox1.Text == report3)
            {
                MessageBox.Show("return Report3");
            }
            else
                MessageBox.Show("No report found; Please try again");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AaiMain main = new AaiMain();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            this.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
