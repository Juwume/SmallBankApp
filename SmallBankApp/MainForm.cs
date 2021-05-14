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
        public bool IsLogin = false;
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
            if (!IsLogin)
            {
                this.Hide();
                LoginForm f = new LoginForm();
                f.ShowDialog(this);
                if (f.isLoggedIn)
                {
                    if (f.isAdmin)
                    {
                        IsLogin = true;
                        this.Show();
                    }
                    else
                    {
                        IsLogin = true;
                        ReportsForm reports = new ReportsForm();
                        reports.ShowDialog(this);
                        this.Close();
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
