using System;
using System.Windows.Forms;

namespace TikTokAdminDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Show a welcome message on form load
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to TikTokAdminDashboard!");
        }
    }
}
