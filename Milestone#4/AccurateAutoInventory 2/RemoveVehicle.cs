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
    public partial class RemoveVehicle : Form
    {
        private string stockNum = "123"; //initial stock # for testing purposes

        public RemoveVehicle()
        {
            InitializeComponent();
        }

        private void Menu2_Click(object sender, EventArgs e)
        {
            AaiMain main = new AaiMain();
            main.Show();
            this.Hide();
        }

        private void Quit2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill in the textbox.");
            }
            else if (textBox1.Text == stockNum)
            {
                MessageBox.Show("Vehicle found");  //once vehicle database is implemented this messagebox can be modified
            }
            else
                MessageBox.Show("Vehicle not found");
        }
    }
}
