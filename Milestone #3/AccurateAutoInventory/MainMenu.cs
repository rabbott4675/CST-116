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
    public partial class AaiMain : Form
    {
        public AaiMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVehicle add = new AddVehicle();
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveVehicle rem = new RemoveVehicle();
            rem.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RunReports report = new RunReports();
            report.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Purge purge = new Purge();
            purge.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
