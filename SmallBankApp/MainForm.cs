using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallBankApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FormsButton_Click(object sender, EventArgs e)
        {
            FormsForm Form = new FormsForm();
            Form.Show();
            this.Hide();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm Form = new ReportsForm();
            Form.Show();
            this.Hide();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoForm Form = new InfoForm();
            Form.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.ShowDialog(this);
            if (f.isLoggedIn)
            {
                if (f.isAdmin)
                {
                    Show();
                }
                else
                {
                    ReportsForm reports = new ReportsForm();
                    reports.ShowDialog(this);
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
    }
}
