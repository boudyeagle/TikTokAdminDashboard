using System;
using System.Windows.Forms;

namespace TikTokAdminDashboard
{
    public partial class Form1 : Form
    {
        TextBox txtUsername;
        NumericUpDown numViewers;
        Label lblResult;

        public Form1()
        {
            InitializeComponent();
            SetupFormUI();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to TikTokAdminDashboard!");
        }

        private void SetupFormUI()
        {
            txtUsername = new TextBox
            {
                PlaceholderText = "Enter TikTok Username",
                Width = 250,
                Top = 30,
                Left = 30
            };
            this.Controls.Add(txtUsername);

            numViewers = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 9999999,
                Value = 1500,
                Top = 70,
                Left = 30,
                Width = 250
            };
            this.Controls.Add(numViewers);

            lblResult = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 14),
                Top = 120,
                Left = 30,
                ForeColor = System.Drawing.Color.DarkBlue,
                Text = "Press F5 to send viewers..."
            };
            this.Controls.Add(lblResult);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string username = txtUsername.Text.Trim();
                int viewers = (int)numViewers.Value;

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a TikTok username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lblResult.Text = $"@{username} is now watching with {viewers:N0} viewers!";
            }
        }
    }
}
