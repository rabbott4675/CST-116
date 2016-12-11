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
    public partial class Purge : Form
    {
        public Purge()
        {
            InitializeComponent();
        }

        private void PButton_Click(object sender, EventArgs e)
        {

        }

        private void Menu5_Click(object sender, EventArgs e)
        {
            AaiMain main = new AaiMain();
            main.Show();
            this.Hide();
        }

        private void Quit5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
