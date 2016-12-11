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
    }
}
